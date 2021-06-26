using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Attendance
{
    public class Attendance : IAttendance
    {
        public string Attendance_EmployeeId { get; private set; }

        private int CurrentMonthAttendedHoursAmount { get; }
        public Attendance(string EmployeeId)
        {
            this.Attendance_EmployeeId = EmployeeId;
            this.CurrentMonthAttendedHoursAmount = 10;
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
