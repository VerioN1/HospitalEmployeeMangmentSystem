using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Job : IJob
    {
        public string Title { get; private set; }

        public IList<string> Roles { get; private set; }

        public int InRiskBonus { get; private set; }

        public int ManagerSalary { get; private set; }

        public Job(string Title, IList<string> Roles, int InRiskBonus = 0)
        {
            this.Title = Title;
            this.Roles = Roles;
            this.InRiskBonus = InRiskBonus;
        }
    }
}
