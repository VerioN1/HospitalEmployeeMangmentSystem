using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Employee : IEmployee
    {
        private string _name { get; }
        private string _id { get; }
        public Employee(string Name, string Id)
        {
            this._name = Name;
            this._id = Id;
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
