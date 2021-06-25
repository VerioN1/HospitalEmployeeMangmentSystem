using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem
{
    public interface IEmployee
    {
        Employee GetEmployee( string id );
        void AddEmployee(Employee employee);

    }
}
