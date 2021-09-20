namespace AlexSoft.AlexUp.DAL
{
    using System;
    using System.Collections.Generic;
    using AlexSoft.AlexUp.DALInterfaces;
    using AlexSoft.AlexUp.Models;

    public class Repository : IRepository
    {
        private static Project[] projects = new Project[]
     {
                new Project
                {
                    Id = new Guid("5a7939fd-59de-44bd-a092-f5d8434584de"),
                    Name = "TeamUp",
                    Contact = new Contact()
                    {
                        Name = "Jose Ecos",
                        IdResume = "123"
                    },
                    Description = "Centralize resumes and project",
                    Logo = "https://www.example.com/images/dinosaur.jpg",
                    MemberList = new List<Contact>
                    {
                        new Contact
                        {
                            Name = "Paola Quintanilla",
                            IdResume = "21"
                        }
                    },
                    State = true,
                    TextInvitation = "You are invited to be part of TeamUp",
                    CreationDate = DateTime.Today.AddDays(-10),
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Lueilwitz Group",
                    Contact = new Contact()
                    {
                        Name = "Jose Ecos",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.example.com/images/dinosaur.jpg",
                    MemberList = new List<Contact>
                    {
                        new Contact
                        {
                            Name = "Paola Quintanilla",
                            IdResume = "412"
                        }
                    },
                    State = true,
                    TextInvitation = "laboriosam cumque consequatur",
                    CreationDate = DateTime.Today.AddDays(-5),
                }
     };

        public IEnumerable<Project> GetAllProjects()
        {
            return projects;
        }

        public string GetHealth()
        {
            return "The CoteApp is alive  and running";
        }
    }
}
