using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class Senior : IRoleHourlyWage
    {
        public string Name { get; private set; } = "Senior";
        public int Percantage { get; private set; } = 5;
        public Senior() { }
        public double CalculateRoleWage(int HoursAttended)
        {
            double percantage = Percantage / 100;
            return percantage * DefaultSallaryConstants.MINIMUM_HOURLY_WAGE * HoursAttended;
        }
    }
}
