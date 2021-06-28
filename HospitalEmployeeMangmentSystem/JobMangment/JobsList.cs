using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalEmployeeMangmentSystem.JobMangment
{
    public class JobsList
    {
        private static JobsList _instance = new JobsList();
        private JobsList() { }
        private IList<IJob> Jobs { get; } = new List<IJob>();
        public static JobsList Instance
        {
            get => _instance;
        }
        public void AddJob(IJob job)
        {
            Jobs.Add(job);
        }
        public IList<IJob> GetAllJobs()
        {
            return Jobs;
        }
        public IJob? GetJobByName(string jobTitle)
        {
            IJob job = Jobs.FirstOrDefault(job => job.Title == jobTitle);
            return job;
        }
    }
}
