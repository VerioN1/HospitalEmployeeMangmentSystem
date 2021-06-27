using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Job : IJob
    {
        public string Title { get; private set; }
        private List<string> Roles;
        public ReadOnlyCollection<string> ReadOnlyRoles => Roles.AsReadOnly();

        public int InRiskBonus { get; private set; }

        public int ManagerSalary { get; private set; }

        public Job(string Title, List<string> Roles, int InRiskBonus = 0 ,int ManagerSalary =0)
        {
            this.Title = Title;
            this.Roles = Roles;
            this.InRiskBonus = InRiskBonus;
            this.ManagerSalary = ManagerSalary;
        }

    }
}
