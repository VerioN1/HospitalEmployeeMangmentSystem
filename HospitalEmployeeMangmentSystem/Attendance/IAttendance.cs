using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IAttendance
    {
        string Attendance_EmployeeId { get; }
        void CheckIn();
        void CheckOut();
        int GetEmployeeAttendanceAmount();
    }
}
