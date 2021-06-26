using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Roles
{
    public class Professional : IRoleHourlyWageBonus
    {
        public int Percantage { get; private set; } = 30;
        private static Professional _instance = new Professional();
        private Professional() { }
        public static Professional Instance { get => _instance; }
        public double RoleBonusWage(int HoursWorked)
        {
            double percantage = Percantage / 100;
            return percantage * DefaultSallaryConstants.MINIMUM_HOURLY_WAGE * HoursWorked;
        }
    }
}
