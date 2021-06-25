using HospitalEmployeeMangmentSystem.Roles.Operations;
using HospitalEmployeeMangmentSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles
{
    public class BasicRole : IRole
    {
        public Title Title { get; private set; }
        private int _percentage;
        public BasicRole(int Percentage, string Name, string TranslatedName)
        {
            this._percentage = Percentage/100;
            Title title = new Title(Name, TranslatedName);
            this.Title = title;
        }
        public void execute(IOperation operation)
        {
            operation.Apply(this);
        }
    }
}
