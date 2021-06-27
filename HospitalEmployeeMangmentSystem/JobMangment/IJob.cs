using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IJob
    {
        string Title { get; }
        int InRiskBonus { get; }
        int ManagerSalary { get; }
        ReadOnlyCollection<string> ReadOnlyRoles { get; }
    }
}
