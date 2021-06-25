using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Salary
{
    public class Salary : ISalary
    {
        public string Salary_EmployeeId { get; private set; }

        public int SalaryAmount { get; private set; }

        public void CalculateEmployeeSalary()
        {
            throw new NotImplementedException();
        }
    }
}
