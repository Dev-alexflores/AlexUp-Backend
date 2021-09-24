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
                        Name = "Cote sanchez",
                        IdResume = "123"
                    },
                    Description = "Centralize resumes and project",
                    Logo = "https://www.vhv.rs/dpng/d/453-4537642_transparent-rilakkuma-clipart-cute-rilakkuma-hd-png-download.png",
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
                    Name = "Cote things",
                    Contact = new Contact()
                    {
                        Name = "Jose Ecos",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.pngfind.com/pngs/m/155-1557179_sticker-sticker-rilakkuma-png-transparent-png.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Cote actions",
                    Contact = new Contact()
                    {
                        Name = "Jose Ecos",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.pngitem.com/pimgs/m/520-5204848_korilakkuma-rilakkuma-coffeetime-cute-cute-rilakkuma-transparent-hd.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Cote is doing something",
                    Contact = new Contact()
                    {
                        Name = "Jose Ecos",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.pngfind.com/pngs/m/155-1557179_sticker-sticker-rilakkuma-png-transparent-png.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Cote casual",
                    Contact = new Contact()
                    {
                        Name = "Jose Ecos",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.pngarea.com/pngm/226/1984451_rilakkuma-png-rilakkuma-png-download.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Cote familiar",
                    Contact = new Contact()
                    {
                        Name = "Cote acciones",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://p.kindpng.com/picc/s/718-7186639_transparent-teddy-bears-hugging-clipart-png-rilakkuma-png.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Lueilwitz Group",
                    Contact = new Contact()
                    {
                        Name = "Cote fulanito",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.pngfind.com/pngs/m/155-1557179_sticker-sticker-rilakkuma-png-transparent-png.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Lueilwitz Group",
                    Contact = new Contact()
                    {
                        Name = "Cote Comelon",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://toppng.com/uploads/preview/rilakkuma-bear-eating-sandwich-oso-kawaii-rilakkuma-11562932340bkih7aombe.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Lueilwitz Group",
                    Contact = new Contact()
                    {
                        Name = "Cote comelona",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.seekpng.com/png/small/160-1605772_korilakkuma-rilakkuma-toast-sandwich-korilakkuma-rilakkuma.png",
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
                },
                new Project
                {
                    Id = new Guid("5a7939fd-59de-33bd-a092-f5d8434584de"),
                    Name = "Lueilwitz Group",
                    Contact = new Contact()
                    {
                        Name = "Cote crianza",
                        IdResume = "222"
                    },
                    Description = "Molestiae numquam possimus sit delectus. Sit ut consequatur est magni. Dolorem voluptatum et distinctio omnis et sit et. Ea soluta optio.",
                    Logo = "https://www.nicepng.com/png/detail/160-1605659_kawaii-cute-japan-rilakkuma-korilakkuma-cuteness-cute-rilakkuma.png",
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
