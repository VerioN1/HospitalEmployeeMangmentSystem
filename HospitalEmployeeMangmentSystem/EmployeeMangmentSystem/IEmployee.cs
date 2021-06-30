using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem
{
    public interface IEmployee
    {
        string Name { get; }
        string Id { get; }
        IJob EmployeeJob { get; }

    }
}
