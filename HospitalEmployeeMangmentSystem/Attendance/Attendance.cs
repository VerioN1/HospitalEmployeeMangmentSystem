using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Attendance : IAttendance
    {
        public string Attendance_EmployeeId { get; private set; }
        //private IList<DateTime>
        private int CurrentMonthAttendedHoursAmount { get; }
        public Attendance(string EmployeeId, int HoursWorked = 0)
        {
            this.Attendance_EmployeeId = EmployeeId;
            this.CurrentMonthAttendedHoursAmount = HoursWorked;
        }

        public void CheckIn()
        {
            throw new NotImplementedException();
        }

        public void CheckOut()
        {
            throw new NotImplementedException();
        }

        public int GetEmployeeAttendanceAmount()
        {
            return CurrentMonthAttendedHoursAmount;
        }
    }
}
