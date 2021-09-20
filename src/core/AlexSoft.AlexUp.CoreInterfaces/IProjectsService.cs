namespace AlexSoft.AlexUp.CoreInterfaces
{
    using System;
    using System.Collections.Generic;
    using System.Text;
    using AlexSoft.AlexUp.Models;

    public interface IProjectsService
    {
        string GetHealth();

        Project[] GetAll();
    }
}
