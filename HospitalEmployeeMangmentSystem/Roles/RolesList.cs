using HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class RolesList
    {
        private static RolesList _instance = new RolesList();
        public IList<IRole> Roles { get; private set; } = new List<IRole>();
        private RolesList() 
        {
            try
            {
                var RoleInterface = typeof(IRole);
                AppDomain.CurrentDomain.GetAssemblies()
               .SelectMany(t => t.GetTypes())
               .Where(t => t.IsClass && t.Namespace == "HospitalEmployeeMangmentSystem.EmployeeMangmentSystem.Roles" && RoleInterface.IsAssignableFrom(t))
               .Select(x => (IRole)Activator.CreateInstance(x))
               .ToList().ForEach(x => Roles.Add(x));
            }
            catch (Exception e)
            {
                Console.WriteLine("Couldn't instintiate all classes" + e);
            }
        }
        public static RolesList Instance { get => _instance; }
        public List<IRole> GetRolesForJob(Job job)
        {
            List<IRole> Roles = new List<IRole>();
            foreach(string RoleName in job.ReadOnlyRoles)
            {
                var Role = GetRole(RoleName);
                if(Role is IRole)
                {
                    Roles.Add(Role);
                }
            }
            return Roles;
        }
        private IRole? GetRole(string RoleName)
        {
            var t = Roles.ToList().FirstOrDefault(x => x.Name.Contains(RoleName));
            if (t is IRole)
            {
                return t;
            }
            Console.WriteLine("Failed to find Role");
            return null;
        }
    }
}
