using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class SalaryMangmentSystem
    {
        private static SalaryMangmentSystem _instance = new SalaryMangmentSystem();
        private List<ISalary> _employees_Salary = new List<ISalary>(); 
        private SalaryMangmentSystem() { }
        public static SalaryMangmentSystem Instance { get => _instance; }
        public ISalary? GetEmployeeSalary(string id)
        {
            var employeeSalary = _employees_Salary.First(x => x.Salary_EmployeeId.Contains(id));
            if(employeeSalary is ISalary)
            {
                return employeeSalary;
            }
            return null;
        }
        public void AddEmployeeToSalarySystem(string Id)
        {
            ISalary salary = new Salary(Id);
            _employees_Salary.Add(salary);
        }

    }
}
