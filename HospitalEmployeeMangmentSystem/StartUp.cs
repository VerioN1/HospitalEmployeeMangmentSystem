using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using System.Linq;
using System.Collections.Generic;
using HospitalEmployeeMangmentSystem.JobMangment;
using System.Xml.Serialization;
using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem;
using HospitalEmployeeMangmentSystem.UI;

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
        public static void InjectGeneratedEmplyeesList()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("GeneratedEmployess.json", optional: true, reloadOnChange: true);
            var Employees = builder.Build().GetSection("Employees");
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<EmployeeXML>), new XmlRootAttribute("EmployeesList"));
                string xmlString = System.IO.File.ReadAllText(Path.Combine(Environment.CurrentDirectory, "EmployeesList.xml"));
                StringReader stringReader = new StringReader(xmlString);
                List<EmployeeXML> EmployeesList = (List<EmployeeXML>)serializer.Deserialize(stringReader);
                EmployeesList.ForEach(employee => ConsoleActions.CreateEmployee(employee.Name, employee.Id, employee.Job, employee.HoursWorked));
                Console.WriteLine("Injected All Employees from XML !");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error While parsing XML, Employees were'nt injected : {e}");
                Console.ReadKey();
            }
        }
        public static void InjectJobsConfiguration()
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
                int.TryParse(JobInRiskBonus, out int InRiskBonus);
                string JobManagerSalary = Job.GetSection("Manager").Value;
                int.TryParse(JobManagerSalary, out int ManagerSalary);
                Job job = new Job(JobTitle, Roles, InRiskBonus, ManagerSalary);
                jobsList.AddJob(job);
            }
        }
    }
}
