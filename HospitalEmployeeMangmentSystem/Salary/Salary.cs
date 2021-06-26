using HospitalEmployeeMangmentSystem.Attendance;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Salary : ISalary
    {
        public string Salary_EmployeeId { get; private set; }

        public int SalaryAmount { get; private set; }
        public Salary(string id)
        {

        }

        public void CalculateEmployeeSalary(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
