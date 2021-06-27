using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.UI
{
    public static class ConsoleController
    {
        public static void Welcome()
        {
            Console.WriteLine("Welcome To Echilov Maternity Department Employee Managment System. \nPress Enter To Continue.\n");
            Console.ReadKey();
            Console.Clear();
        }
        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose Opration \n");
            Console.WriteLine("1) Show All Employees \n");
            Console.WriteLine("2) Add new Employee to the system \n");
            Console.WriteLine("3) Check Employee In & Out \n");
            Console.WriteLine("4) Calculate Employee Salary \n");
            Console.WriteLine("Press the number that represents your selection\n");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
