using System;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace HospitalEmployeeMangmentSystem
{
    public static class StartUp
    {
        public static string LoadConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("Config.json", optional: true, reloadOnChange: true);

            var val = builder.Build().GetSection("Rules").GetSection("test").Value;
            return val;
        }
    }
}
