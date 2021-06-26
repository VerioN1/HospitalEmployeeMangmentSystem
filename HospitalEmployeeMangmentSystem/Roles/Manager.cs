using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class Manager : IRolePureWage
    {
        private static Manager _instance = new Manager();
        private Manager() { }
        public static Manager Instance { get => _instance; }
        public double CalculateRoleWage(IJob job)
        {
            return job.ManagerSalary;
        }

    }
}
