using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class DecisionMaker : IRoleHourlyWage
    {
        private const int MINIMAL_WORKING_HOURS = 50;
        private const int ROUNDED_UP_HOURS = 200;
        private const int PERCENTAGE = 50;
        public string Name { get; private set; } = "DecisionMaker";
        
        public int Percantage { get; private set; } = PERCENTAGE;


        public double CalculateRoleWage(int HoursAttended)
        {
            double percentage = PERCENTAGE / 100;
            if (MINIMAL_WORKING_HOURS > HoursAttended)
            {
                return 0;
            }
            return HoursAttended * percentage * ROUNDED_UP_HOURS;
        }
    }
}
