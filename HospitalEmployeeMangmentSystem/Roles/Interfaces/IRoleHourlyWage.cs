using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IRoleHourlyWage : IRole
    {
        double CalculateRoleWage(int HoursAttended);
    }
}
