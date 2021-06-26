using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class DecisionMaker : IRoleHourlyWageBonus
    {
        private const int MINIMAL_WORKING_HOURS = 50;
        private const int ROUNDED_UP_HOURS = 200;
        private const int PERCENTAGE = 50;
        private static DecisionMaker _instance = new DecisionMaker();
        private DecisionMaker() { }
        public static DecisionMaker Instance { get => _instance; }
        public int Percantage { get; private set; } = PERCENTAGE;

        public double RoleBonusWage(int HoursWorked)
        {
            double percentage = PERCENTAGE / 100;
            if (MINIMAL_WORKING_HOURS > HoursWorked)
            {
                return 0;
            }
            return ROUNDED_UP_HOURS * percentage * DefaultSallaryConstants.MINIMUM_HOURLY_WAGE;
        }
    }
}
