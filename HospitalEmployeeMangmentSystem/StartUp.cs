using System;
using Microsoft.Extensions.Configuration;
using System.IO;
using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;

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
        public static void InjectConfiguration()
        {
            var config = LoadConfiguration();
            var Roles = config.GetSection("Roles");
            foreach(var Role in Roles.GetChildren())
            {
                if(Role.Key == "BasicRoles")
                {
                    //instantiate Basic Roles
                }
                Console.WriteLine(Role.Key);
            }
        }
    }
}
