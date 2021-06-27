using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalEmployeeMangmentSystem
{
    public class AttendanceManagmentSystem
    {
        private static AttendanceManagmentSystem _instance = new AttendanceManagmentSystem();
        private IList<IAttendance> EmployeesAttendancesList = new List<IAttendance>();
        private AttendanceManagmentSystem() { }
        public static AttendanceManagmentSystem Instance {get => _instance;}
        public IAttendance GetEmployeeAttendance(string EmployeeId)
        {
            IAttendance attendace = EmployeesAttendancesList.First(x => x.Attendance_EmployeeId.Contains(EmployeeId));
            return attendace; 
        }
        public void AddEmployeeToAttendancesList(string EmployeeId)
        {
            IAttendance attendance = new Attendance(EmployeeId);
            EmployeesAttendancesList.Add(attendance);
        }
    }
}
