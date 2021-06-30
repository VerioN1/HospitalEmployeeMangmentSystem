using System;
using System.Collections.Generic;
using System.Configuration;
using System.Text;

namespace HospitalEmployeeMangmentSystem.UI
{
    public static class ConsoleValidators
    {
        static EmployeesMangmentSystem EmpMgmtSys = EmployeesMangmentSystem.Instance;
        delegate bool ValidationsChecks();
        public static void MenuSelectionValidation(char input)
        {
            switch (input)
            {
                case '1':
                    ConsoleController.AddNewEmployee();
                    break;
                case '2':
                    ConsoleController.ShowAllEmployees();
                    break;
                case '3':
                    ConsoleController.EmployeeAttendanceSystem();
                    break;
                case '4':
                    ConsoleController.CalculateEmployeeSalary();
                    break;
                default:
                    MenuSelectionValidation(ConsoleController.MainMenu());
                    break;
            }
        }

        internal static bool ValidEmployeeName(string employeeName)
        {
            var StrValidator = new StringValidator(2, 14, "123456789.,!@#$%^&*()");
            try
            {
                StrValidator.Validate(employeeName);
                return true;
            }catch (Exception)
            {
                Console.WriteLine("Employee Name Contains INVALID Charchters. Please try again!");
                Console.ReadKey();
                return false;
            }
        }
        
        internal static bool ValidEmpolyeeId(string employeeId)
        {
            bool DoesEmployeeExists = EmpMgmtSys.DoesEmployeeExists(employeeId);
            if (DoesEmployeeExists)
            {
                Console.WriteLine("Employee Already Exsits With that Id .Please try again!");
                Console.ReadKey();
                return false;
            }
            return true;
        }

        internal static bool ValidJobTitle(string JobTitle)
        {
            IJob? job = JobMangment.JobsList.Instance.GetJobByName(JobTitle);
            if(job is null)
            {
                Console.WriteLine("The job you typed does not exsits. Please try again, heres a list of all the jobs again:");
                JobMangment.JobsList.Instance.GetAllJobs().ForEach(x => Console.WriteLine(x.Title));
                Console.ReadKey();
                return false;
            }
            return true;
        }

        internal static bool ValidEmpolyeeIdExsits(string employeeIdInput)
        {
            Console.WriteLine($"Status - {EmpMgmtSys.DoesEmployeeExists(employeeIdInput)}");
            return true;
        }
    }
}
