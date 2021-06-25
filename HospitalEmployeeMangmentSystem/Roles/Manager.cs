using HospitalEmployeeMangmentSystem.Roles.Operations;
using HospitalEmployeeMangmentSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class Manager : IRole
    {
        public Title Title { get; private set; }

        public void execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
