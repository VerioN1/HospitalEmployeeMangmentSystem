using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalEmployeeMangmentSystem.UI
{
    public static class ConsoleController
    {
        static EmployeesMangmentSystem EmpMgmtSys = EmployeesMangmentSystem.Instance;
        public static void Welcome()
        {
            Console.WriteLine("Welcome To Echilov Maternity Department Employee Managment System. \nPress Enter To Continue.\n");
            Console.ReadKey();
            Console.Clear();
        }
        public static char MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose Opration \n");
            Console.WriteLine("1) Add new Employee to the system \n");
            Console.WriteLine("2) Show All Employees \n");
            Console.WriteLine("3) Check Employee In & Out \n");
            Console.WriteLine("4) Calculate Employee Salary \n");
            Console.WriteLine("Press the number that represents your selection\n");
            var Selection = Console.ReadKey();
            Console.Clear();
            return Selection.KeyChar;
        }
        public static void ShowAllEmployees()
        {
            var EmployeesList = EmpMgmtSys.GetAllEmployees();
            foreach(Employee Employee in EmployeesList)
            {
                Console.WriteLine($"Name: {Employee.Name}");
                Console.WriteLine($"Employee ID: {Employee.Id}");
                Console.WriteLine($"Job: {Employee.EmployeeJob.Title} \n");
            }
            Console.WriteLine("Press Enter to Go Back To Main Menu");
            Console.ReadKey();
            Console.Clear();
            ConsoleValidators.MenuSelectionValidation(MainMenu());
        }
        public static void AddNewEmployee()
        {
            string[] ArgumentsStrings = new string[] { "Enter Employee Name : ", "Enter Employee Id : ", "Enter Employee's Job Title : " };
            string[] WarningString = new string[] { "Must not contain Spacial Chars OR Numbers!", "Must be a unique Id", "Make sure you're typing job that exsits" };
            Func<string, bool>[] ValidatorsMethods = new Func<string, bool>[] { ConsoleValidators.ValidEmployeeName, ConsoleValidators.ValidEmpolyeeId, ConsoleValidators.ValidJobTitle };
            List<string> UserInputs = new List<string>();
            foreach(var Argument in ArgumentsStrings.Select((value, i) => new { i, value}))
            {
                string UserInput;
                bool valid = false;
                do
                {
                    Console.Clear();
                    Console.WriteLine("Creating New Employee Process \n");
                    Console.WriteLine(Argument.value);
                    Console.WriteLine(WarningString[Argument.i]);
                    UserInput = Console.ReadLine();
                    valid = ValidatorsMethods[Argument.i](UserInput);
                    Console.Clear();
                } while (valid == false);
                UserInputs.Add(UserInput);
            }
            //need to fix this horrible implemntation
            ConsoleActions.CreateEmployee(UserInputs[0], UserInputs[1], UserInputs[2]);
            ConsoleValidators.MenuSelectionValidation(MainMenu());
        }
        public static void CalculateEmployeeSalary()
        {
            string EmployeeIdInput;
                Console.WriteLine("Employee Salary Calculator \n");
                Console.WriteLine("Enter Employee Id : ");
                EmployeeIdInput = Console.ReadLine().ToString();
                Console.WriteLine($"{EmployeeIdInput} - is type - {EmployeeIdInput.GetType()}");
            bool isValid = EmployeesMangmentSystem.Instance.DoesEmployeeExists(EmployeeIdInput);
            if (isValid)
            {
                ConsoleActions.ProcessEmployeeSalaryCalculation(EmployeeIdInput);
            }
            Console.WriteLine("Failed to Valid");
            Console.ReadKey();
            ConsoleValidators.MenuSelectionValidation(MainMenu());
        }


    }
}
