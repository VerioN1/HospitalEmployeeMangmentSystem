using HospitalEmployeeMangmentSystem.UI;

namespace HospitalEmployeeMangmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StartUp.InjectJobsConfiguration();
            StartUp.InjectGeneratedEmplyeesList();
            ConsoleController.Welcome();
            ConsoleValidators.MenuSelectionValidation(ConsoleController.MainMenu());
        }
    }
}
