namespace AlexSoft.AlexUp.ApiUnitTests
{
    using AlexSoft.AlexUp.CoreInterfaces;
    using AlexSoft.AlexUp.Models;
    using AlexSoft.AlexUp.Projects;
    using AlexSoft.AlexUp.Projects.Controllers;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Moq;
    using Xunit;

    public class GetProjectsTests
    {
        private readonly Mock<IProjectsService> mockService;
        private readonly DefaultHttpContext mockHttpContext;
        private readonly GetHealth getHealth;
        private readonly GetProjects getAll;

        public GetProjectsTests()
        {
            this.mockService = new Mock<IProjectsService>();
            this.mockHttpContext = new DefaultHttpContext();
            this.getHealth = new GetHealth(this.mockService.Object);
            this.getAll = new GetProjects(this.mockService.Object);
        }

        [Fact]
        public void GetHealth_ShouldReturnTextOk()
        {
            // Arrange
            var request = this.mockHttpContext.Request;
            this.mockService.Setup(service => service.GetHealth()).Returns("string");

            // Act
            var result = this.getHealth.Health(request);

            // Assert
            var okObjectResult = Assert.IsType<OkObjectResult>(result);
            Assert.IsType<string>(okObjectResult.Value);
        }

        [Fact]
        public void GetAllProjects_shouldReturn_AllProjects()
        {
            // Arrange
            Project[] projects = new Project[2];
            projects[0] = StubProject.GetStubProject();
            var request = this.mockHttpContext.Request;
            this.mockService.Setup(service => service.GetAll()).Returns(projects);

            // Act
            var response = this.getAll.Run(request);

            // Assert
            var okObjectResult = Assert.IsType<OkObjectResult>(response);
            Assert.IsType<Project[]>(okObjectResult.Value);
        }
    }
}
