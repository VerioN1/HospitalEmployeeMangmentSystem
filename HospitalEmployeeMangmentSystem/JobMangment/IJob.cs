using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IJob
    {
        string Title { get; }
        int InRiskBonus { get; }
        int ManagerSalary { get; }
        IList<string> Roles { get; }
    }
}
