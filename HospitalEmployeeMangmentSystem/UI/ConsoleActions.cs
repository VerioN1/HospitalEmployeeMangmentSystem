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
            EmployeeSalary.CalculateEmployeeSalary(employee);
            Console.WriteLine("Press any key to return to main menu");
            Console.ReadKey();
        }

        public static void CheckInEmployee(string EmployeeId)
        {
            Console.WriteLine("checked in System ");
            Attendance EmployeeAttendance = AttendanceManagmentSystem.Instance.GetEmployeeAttendance(EmployeeId);
            var CheckInTime = CheckEmployeeTime();
            if(CheckInTime is null)
            {
                return;
            }
            EmployeeAttendance.CheckIn(CheckInTime[0], CheckInTime[1]);
            Console.WriteLine($"Check In At {CheckInTime[0]}:{CheckInTime[1]}");
            Console.ReadKey();
        }
        public static void CheckOutEmployee(string EmployeeId)
        {
            Console.WriteLine("checked Out System");
            Attendance EmployeeAttendance = AttendanceManagmentSystem.Instance.GetEmployeeAttendance(EmployeeId);
            var CheckInTime = CheckEmployeeTime();
            if (CheckInTime is null)
            {
                return;
            }
            EmployeeAttendance.CheckOut(CheckInTime[0], CheckInTime[1]);
            Console.WriteLine($"Check out At {CheckInTime[0]}:{CheckInTime[1]}");
            Console.ReadKey();
        }
        public static void ShowAllAttendancesSchedual(string EmployeeId)
        {
            Attendance EmployeeAttendance = AttendanceManagmentSystem.Instance.GetEmployeeAttendance(EmployeeId);
            var EmployeeScheduale = EmployeeAttendance.GetEmployeeSchedual();
            foreach(var scheduale in EmployeeScheduale)
            {
                foreach(KeyValuePair<string, int> checkInOut in scheduale)
                {
                    Console.WriteLine($"At {checkInOut.Key} , you worked for - {checkInOut.Value} hours");
                }
            }
            Console.ReadKey();
        }
        public static int[]? CheckEmployeeTime()
        {

            Console.WriteLine("The hour you checked : ");
            Console.WriteLine("enter number between 1 to 24, for example - if you Checked at 14:23 - enter 14 now");
            string HourInput = Console.ReadLine();
            Int32.TryParse(HourInput, out int Hours);
            Console.Clear();
            Console.WriteLine("The minute you checked : ");
            Console.WriteLine("enter number between 1 to 24, for example - if you Checked at 14:23 - enter 23 now");
            string MinutesInput = Console.ReadLine();
            Int32.TryParse(MinutesInput, out int Minutes);
            if (Minutes <= 0 || Hours <= 0 || Minutes > 59 || Hours > 24)
            {
                Console.WriteLine("Your Input was invalid, please try again.");
                Console.ReadKey();
                Console.Clear();
                return null;
            }
            return new int[] {Hours, Minutes };
        }
    }
}
