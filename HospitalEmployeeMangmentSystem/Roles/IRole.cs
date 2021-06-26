using HospitalEmployeeMangmentSystem.Roles.Operations;
using HospitalEmployeeMangmentSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public interface IRole
    {
        Title Title { get; }
        void execute(IOperation operation);
    }
}
