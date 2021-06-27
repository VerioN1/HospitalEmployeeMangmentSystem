using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class EmployeesMangmentSystem
    {
        private List<Employee> _employees = new List<Employee>();
        private static EmployeesMangmentSystem _instance = new EmployeesMangmentSystem();
        private EmployeesMangmentSystem() { }
        public static EmployeesMangmentSystem Instance { get => _instance; }
        public IReadOnlyCollection<Employee> GetAllEmployees()
        {
            return _employees.AsReadOnly();
        }
        public void CreateNewEmployee(string Name, string Id, Job job)
        {
            Employee employee = new Employee(Name, Id, job);
            _employees.Add(employee);
            AttendanceManagmentSystem.Instance.AddEmployeeToAttendancesList(Id);
            SalaryMangmentSystem.Instance.AddEmployeeToSalarySystem(Id);
        }
        public Employee? GetEmployee(string id)
        {
            var employee = _employees.Find(x => x.Id.Contains(id));
            if(employee is Employee)
            {
                return employee;
            }
            return null;
        }
    }
}
