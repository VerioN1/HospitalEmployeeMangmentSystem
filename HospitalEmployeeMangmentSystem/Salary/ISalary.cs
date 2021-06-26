using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface ISalary
    {
        string Salary_EmployeeId { get; }
        int SalaryAmount { get; }
        void CalculateEmployeeSalary(Employee employee);
    }
}
