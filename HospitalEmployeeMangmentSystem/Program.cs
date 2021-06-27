using HospitalEmployeeMangmentSystem.JobMangment;
using System;

namespace HospitalEmployeeMangmentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            JobsList jobsList = StartUp.InjectJobsConfiguration();

            Console.WriteLine("test \n");
            
            foreach(IJob job in jobsList.GetAllJobs())
            {
               
            }
        }
    }
}
