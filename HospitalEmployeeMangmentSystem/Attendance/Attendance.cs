using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Attendance : IAttendance
    {
        public string Attendance_EmployeeId { get; private set; }
        private List<Dictionary<String, int>> EmployeeAttendanceSchedual = new List<Dictionary<String, int>>();
        private TimeSpan CheckInTimeStamp;
        private int CurrentMonthAttendedHoursAmount { get; set; }
        public Attendance(string EmployeeId, int HoursWorked = 0)
        {
            this.Attendance_EmployeeId = EmployeeId;
            this.CurrentMonthAttendedHoursAmount = HoursWorked;
        }

        public void CheckIn(int Hours, int Minutes)
        {
            TimeSpan CheckInTime = new TimeSpan(Hours, Minutes, 0);
            this.CheckInTimeStamp = CheckInTime;
        }

        public void CheckOut(int Hours, int Minuts)
        {
            if(CheckInTimeStamp.Ticks == 0)
            {
                Console.WriteLine("No Check In Recorded On This Employee, Please Check In First");
                Console.ReadKey();
                return;
            }
            TimeSpan CheckOutTime = new TimeSpan(Hours, Minuts, 0);
            int TotalHoursWorked = Math.Abs(Convert.ToInt32(CheckInTimeStamp.Subtract(CheckOutTime).TotalHours));
            Console.WriteLine($"Checked out At {Hours}:{Minuts}");
            Console.WriteLine($"You Worked For : {TotalHoursWorked} Hours");
            this.CurrentMonthAttendedHoursAmount += TotalHoursWorked;
            EmployeeAttendanceSchedual.Add(new Dictionary<string, int>() { { $"{DateTime.Now.ToString("U")}", TotalHoursWorked } });
            this.CheckInTimeStamp = new TimeSpan();
        }
        public IReadOnlyCollection<Dictionary<String, int>> GetEmployeeSchedual()
        {
            return EmployeeAttendanceSchedual.AsReadOnly();
        }

        public int GetEmployeeAttendanceAmount()
        {
            return CurrentMonthAttendedHoursAmount;
        }
    }
}
