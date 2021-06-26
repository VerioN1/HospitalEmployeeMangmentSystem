using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalEmployeeMangmentSystem.Attendance
{
    public class EmployeesAttendance
    {
        private static EmployeesAttendance _instance = new EmployeesAttendance();
        private IList<IAttendance> EmployeesAttendancesList = new List<IAttendance>();
        private EmployeesAttendance() { }
        public static EmployeesAttendance Instance {get => _instance;}
        public IAttendance GetEmployeeAttendance(string EmployeeId)
        {
            IAttendance attendace = EmployeesAttendancesList.First(x => x.Attendance_EmployeeId.Contains(EmployeeId));
            return attendace; 
        }
        public void AddEmployeeToAttendancesList(IAttendance attendance)
        {
            EmployeesAttendancesList.Add(attendance);
        }
    }
}
