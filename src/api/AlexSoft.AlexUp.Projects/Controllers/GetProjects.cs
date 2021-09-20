namespace AlexSoft.AlexUp.Projects
{
    using System.IO;
    using System.Net;
    using AlexSoft.AlexUp.CoreInterfaces;
    using Microsoft.AspNetCore.Http;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.Azure.WebJobs;
    using Microsoft.Azure.WebJobs.Extensions.Http;
    using Microsoft.Azure.WebJobs.Extensions.OpenApi.Core.Attributes;
    using Microsoft.Extensions.Primitives;
    using Microsoft.OpenApi.Models;

    public class GetProjects
    {
        private readonly IProjectsService iprojectservice;

        public GetProjects(IProjectsService iprojectservice)
        {
            this.iprojectservice = iprojectservice;
        }

        [FunctionName("getAll")]
        [OpenApiOperation(operationId: "GetAll", tags: new[] { "name" })]

        // [OpenApiParameter(name: "id", In = ParameterLocation.Query, Required = true, Type = typeof(int), Description = "The **Name** parameter")]
        [OpenApiResponseWithBody(statusCode: HttpStatusCode.OK, contentType: "text/plain", bodyType: typeof(string), Description = "The OK response")]
        public IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = "v1/projects")] HttpRequest req)
        {
            // req.Query.TryGetValue("id", out StringValues id);
            // int? idProject;
            // idProject = int.Parse(id);
            var result = this.iprojectservice.GetAll();
            return new OkObjectResult(result);
        }
    }
}