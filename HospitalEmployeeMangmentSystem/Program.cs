using HospitalEmployeeMangmentSystem.JobMangment;
using System;

namespace HospitalEmployeeMangmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            JobsList jobsList = StartUp.InjectJobsConfiguration();
            foreach(var job in jobsList.GetAllJobs())
            {
                Console.WriteLine(job.Roles[0]);
            }
        }
    }
}
