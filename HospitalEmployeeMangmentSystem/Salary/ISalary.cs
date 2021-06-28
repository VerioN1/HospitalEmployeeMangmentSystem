using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface ISalary
    {
        string Salary_EmployeeId { get; }
        double SalaryAmount { get; }
        double CalculateEmployeeSalary(Employee employee);
    }
}
