using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IRoleHourlyWageBonus
    {
        int Percantage { get; }
        double RoleBonusWage(int HoursWorked);
    }
}
