using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Roles
{
    public class Senior : IRoleHourlyWageBonus
    {
        public int Percantage { get; private set; } = 5;
        private static Senior _instance = new Senior();
        private Senior() { }
        public static Senior Instance { get => _instance; }
        public double RoleBonusWage(int HoursWorked)
        {
            double percantage = Percantage / 100;
            return percantage * DefaultSallaryConstants.MINIMUM_HOURLY_WAGE * HoursWorked;
        }
    }
}
