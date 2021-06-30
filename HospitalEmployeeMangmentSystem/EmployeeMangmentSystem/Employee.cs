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

        public IJob EmployeeJob { get; private set; }

        public Employee(string Name, string Id, IJob job)
        {
            this.Name = Name;
            this.Id = Id;
            this.EmployeeJob = job;
        }

        public void AddEmployee(Employee employee)
        {
            //Add new employeee to EmployeesList
            throw new NotImplementedException();
        }
    }
}
