using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IRolePureWageBonus
    {
        double CalculateRoleWage(IJob job, int CurrentSalary);
    }
}
