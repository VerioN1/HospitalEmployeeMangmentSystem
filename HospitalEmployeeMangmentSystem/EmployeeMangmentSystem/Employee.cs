using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Employee : IEmployee
    {
        public string Name { get; private set; }
        public string Id { get; private set; }
        public Employee(string Name, string Id)
        {
            this.Name = Name;
            this.Id = Id;
        }
        public Employee GetEmployee(string Id)
        {
            throw new NotImplementedException();
        }

        public void AddEmployee(Employee employee)
        {
            throw new NotImplementedException();
        }
    }
}
