using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IRolePureWage
    {
        double CalculateRoleWage(IJob job);
    }
}
