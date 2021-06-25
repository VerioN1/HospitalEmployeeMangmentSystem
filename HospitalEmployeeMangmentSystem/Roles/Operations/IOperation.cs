using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Roles.Operations
{
    public interface IOperation
    {
        void Apply(Manager manager);
        void Apply(BasicRole basicRole);
        void Apply(InRisk inRisk);
        void Apply(DecisionMaker decisionMaker);
    }
}
