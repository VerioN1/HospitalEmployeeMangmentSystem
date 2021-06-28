using HospitalEmployeeMangmentSystem.JobMangment;
using HospitalEmployeeMangmentSystem.UI;
using System;

namespace HospitalEmployeeMangmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp.InjectJobsConfiguration();
            ConsoleController.Welcome();
            ConsoleActions.CreateEmployee("Alon", "1234", "Department Manager");
            ConsoleValidators.MenuSelectionValidation(ConsoleController.MainMenu());
        }
    }
}
