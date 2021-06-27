using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class Manager : IRoleMonthlyWage
    {
        public string Name { get; private set; } = "Manager";
        public Manager() { }

        public double CalculateRoleWage(Employee employee, double CurrentSalary)
        {
            double ManagerSalary = employee.EmployeeJob.ManagerSalary;
            return ManagerSalary;
        }
    }
}
