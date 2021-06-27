using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class Junior : IRoleHourlyWage
    {
        public string Name { get; private set; } = "Junior";
        public int Percantage { get; private set; } = 0;
        public Junior() { }
        public double CalculateRoleWage(int HoursAttended)
        {
            double percantage = Percantage / 100;
            return percantage * DefaultSallaryConstants.MINIMUM_HOURLY_WAGE * HoursAttended;
        }

    }
}
