using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IRoleMonthlyWage : IRole
    {
        double CalculateRoleWage(Employee employee, double CurrentSalary);
    }
}
