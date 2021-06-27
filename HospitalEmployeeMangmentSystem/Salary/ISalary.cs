using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface ISalary
    {
        string Salary_EmployeeId { get; }
        double SalaryAmount { get; }
        int WorkingHours { get; }
        double CalculateEmployeeSalary(Employee employee);
    }
}
