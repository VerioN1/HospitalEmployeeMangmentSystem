using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Roles.Operations
{
    class CalculateRoleWageOperation : IOperation
    {
        public void Apply(Manager manager)
        {
            Console.WriteLine("manager wage");
        }

        public void Apply(BasicRole basicRole)
        {
            Console.WriteLine("basic wage");
        }

        public void Apply(InRisk inRisk)
        {
            Console.WriteLine("in Risk wage");
        }

        public void Apply(DecisionMaker decisionMaker)
        {
            Console.WriteLine("DecisionMaker wage");
        }
    }
}
