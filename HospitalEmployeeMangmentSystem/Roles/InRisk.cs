using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class InRisk : IRolePureWageBonus
    {
        private static InRisk _instance = new InRisk();
        private InRisk() { }
        public static InRisk Instance { get => _instance; }
        public double CalculateRoleWage(IJob job, int CurrentSalary)
        {
            var percantage = job.InRiskBonus / 100;
            return CurrentSalary * percantage;
        }
    }
}
