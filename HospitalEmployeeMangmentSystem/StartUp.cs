using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using HospitalEmployeeMangmentSystem.JobMangment;

namespace HospitalEmployeeMangmentSystem
{
    public static class StartUp
    {
        public static IConfiguration LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Config.json", optional: true, reloadOnChange: true);
            var config = builder.Build();
            return config;
        }
        public static JobsList InjectJobsConfiguration()
        {
            var config = LoadConfiguration();
            JobsList jobsList = JobsList.Instance;
            var Jobs = config.GetSection("Jobs");
            foreach(var Job in Jobs.GetChildren())
            {
                List<string> Roles = new List<string>();
                string JobTitle = (Job.Key);
                foreach(var Role in Job.GetSection("Roles").AsEnumerable())
                {
                    if(Role.Value != null && Role.Value is string)
                    {
                        Roles.Add(Role.Value);
                    }
                }
                string JobInRiskBonus = Job.GetSection("InRiskBonus").Value;
                int Bonus = 0;
                int.TryParse(JobInRiskBonus, out Bonus);
                Job job = new Job(JobTitle, Roles, Bonus);
                jobsList.AddJob(job);
            }
            return jobsList;
        }
      
    }
}
