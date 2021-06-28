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
                    ConsoleController.CalculateEmployeeSalary();
                    break;
                default:
                    MenuSelectionValidation(ConsoleController.MainMenu());
                    break;
            }
        }

        internal static bool ValidEmployeeName(string employeeName)
        {
            var StrValidator = new StringValidator(1, 14, "123456789.,!@#$%^&*()");
            try
            {
                StrValidator.Validate(employeeName);
                return true;
            }catch (Exception)
            {
                return false;
            }
        }
        
        internal static bool ValidEmpolyeeId(string employeeId)
        {
            bool DoesEmployeeExists = EmpMgmtSys.DoesEmployeeExists(employeeId);
            if (DoesEmployeeExists)
            {
                Console.WriteLine("User Already Exsits With that Id , press enter to retry");
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
