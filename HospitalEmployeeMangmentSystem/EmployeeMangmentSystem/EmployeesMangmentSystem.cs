﻿using System;
using System.Collections.Generic;
using System.Linq;
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
        public void CreateNewEmployee(string Name, string Id, IJob? job)
        {
            if (job is null)
            {
                Console.WriteLine("Failed Creating Employee");
            }
            else
            {
                Employee employee = new Employee(Name, Id, job);
                _employees.Add(employee);
                AttendanceManagmentSystem.Instance.AddEmployeeToAttendancesList(Id);
                SalaryMangmentSystem.Instance.AddEmployeeToSalarySystem(Id);
                Console.WriteLine("success in creating Employee");
            }
        }
        public Employee? GetEmployee(string Id)
        {
            var employee = _employees.Find(x => String.Equals(x.Id, Id));
            if(employee is Employee)
            {
                Console.WriteLine("Got Employee");
                return employee;
            }
            return null;
        }
        public bool DoesEmployeeExists(string Id)
        {
            var MatchingEmployee = _employees.Find(x => String.Equals(x.Id, Id));
            if(MatchingEmployee is null)
            {
                Console.WriteLine("Got Employee Failed");
                return false;
            }
            return true;
        }
    }
}