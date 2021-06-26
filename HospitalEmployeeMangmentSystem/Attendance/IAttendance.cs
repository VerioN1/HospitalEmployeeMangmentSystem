using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Attendance
{
    interface IAttendance
    {
        string Attendance_EmployeeId { get; }
        int CurrentMonthAttendedHoursAmount { get; }

        void CheckIn();
        void CheckOut();
        void GetEmployeeMonthHoursAttendance();
    }
}
