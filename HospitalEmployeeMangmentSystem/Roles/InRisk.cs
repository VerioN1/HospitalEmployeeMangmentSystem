using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class InRisk : IRoleMonthlyWage
    {
        public string Name { get; private set; } = "InRisk";
        public InRisk() { }
        public double CalculateRoleWage(Employee employee, double CurrentSalary)
        {
            double percantage = employee.EmployeeJob.InRiskBonus / 100;
            return CurrentSalary * percantage;
        }
    }
}
