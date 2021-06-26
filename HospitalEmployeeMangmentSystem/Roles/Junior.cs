using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Roles
{
    public class Junior : IRoleHourlyWageBonus
    {
        public int Percantage { get; private set; } = 0;
        private static Junior _instance = new Junior();
        private Junior() { }
        public static Junior Instance { get => _instance; }
        public double RoleBonusWage(int HoursWorked)
        {
            double percantage = Percantage / 100;
            return percantage * DefaultSallaryConstants.MINIMUM_HOURLY_WAGE * HoursWorked;
        }
    }
}
