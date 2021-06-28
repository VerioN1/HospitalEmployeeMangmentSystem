using HospitalEmployeeMangmentSystem.JobMangment;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.UI
{
    public static class ConsoleActions
    {
        public static void CreateEmployee(string Name, string Id , string JobName)
        {
            Console.WriteLine("Creating Employee");
            IJob? Job = JobsList.Instance.GetJobByName(JobName);
            EmployeesMangmentSystem.Instance.CreateNewEmployee(Name, Id, Job);
            Console.ReadKey();
            Console.Clear();
        }
        public static void ProcessEmployeeSalaryCalculation(string EmployeeId)
        {
            Employee? employee = EmployeesMangmentSystem.Instance.GetEmployee(EmployeeId);
            ISalary? EmployeeSalary = SalaryMangmentSystem.Instance.GetEmployeeSalary(EmployeeId);
            if(EmployeeSalary is null || employee is null)
            {
                Console.WriteLine("Error While Searching for Employee salary");
                Console.ReadKey();
                return;
            }
            Console.WriteLine("got to Calculation PHASE");
            double EmployeeCalculatedSalary = EmployeeSalary.CalculateEmployeeSalary(employee);
            Console.WriteLine($"{employee.Name}'s Salary - {EmployeeCalculatedSalary}");
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();
        }
    }
}
