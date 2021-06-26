using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using HospitalEmployeeMangmentSystem.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace HospitalEmployeeMangmentSystem.Job
{
    public interface IJob
    {
        Title Title { get; }
        ICollection<IRole> Roles { get; }
    }
}
