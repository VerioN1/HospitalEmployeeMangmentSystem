using System;
using System.Collections.Generic;
using System.Linq;

namespace HospitalEmployeeMangmentSystem
{
    public class AttendanceManagmentSystem
    {
        private static AttendanceManagmentSystem _instance = new AttendanceManagmentSystem();
        private List<Attendance> EmployeesAttendancesList = new List<Attendance>();
        private AttendanceManagmentSystem() { }
        public static AttendanceManagmentSystem Instance {get => _instance;}
        public Attendance GetEmployeeAttendance(string EmployeeId)
        {
            Attendance attendace = EmployeesAttendancesList.First(x => x.Attendance_EmployeeId.Contains(EmployeeId));
            return attendace; 
        }
        public void AddEmployeeToAttendancesList(string EmployeeId, int HoursWorked = 0)
        {
            Attendance attendance = new Attendance(EmployeeId, HoursWorked);
            EmployeesAttendancesList.Add(attendance);
        }
    }
}
