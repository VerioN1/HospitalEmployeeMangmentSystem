using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using HospitalEmployeeMangmentSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Job
{
    public class Job : IJob
    {
        public Title Title => throw new NotImplementedException();

        public ICollection<IRole> Roles => throw new NotImplementedException();
    }
}
