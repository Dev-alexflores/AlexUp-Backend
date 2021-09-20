namespace AlexSoft.AlexUp.Core
{
    using System;
    using System.Linq;
    using AlexSoft.AlexUp.CoreInterfaces;
    using AlexSoft.AlexUp.DALInterfaces;
    using AlexSoft.AlexUp.Models;

    public class ProjectsService : IProjectsService
    {
        private readonly IRepository repository;

        public ProjectsService(IRepository irepository)
        {
            this.repository = irepository;
        }

        public Project[] GetAll()
        {
            var result = this.repository.GetAllProjects();
            return result.ToArray();
        }

        public string GetHealth()
        {
            return this.repository.GetHealth();
        }
    }
}
