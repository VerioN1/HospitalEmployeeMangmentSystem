using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public interface IAttendance
    {
        string Attendance_EmployeeId { get; }
        void CheckIn(int Time, int Time2);
        void CheckOut(int Time, int Time2);
        int GetEmployeeAttendanceAmount();
    }
}
