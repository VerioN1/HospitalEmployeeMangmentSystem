using HospitalEmployeeMangmentSystem.Roles.Operations;
using HospitalEmployeeMangmentSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class InRisk : IRole
    {
        public Title Title { get; private set; }
        private int _percentage { get; }
        public InRisk(int Percentage)
        {
            this._percentage = Percentage;
        }

        public void execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
