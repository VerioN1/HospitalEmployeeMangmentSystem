using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Salary : ISalary
    {
        public string Salary_EmployeeId { get; private set; }

        public double SalaryAmount { get; private set; }

        public int WorkingHours { get; private set; }

        public Salary(string EmployeeId)
        {
            this.Salary_EmployeeId = EmployeeId;
            this.WorkingHours = 9;
            this.SalaryAmount = 0;
        }

        public double CalculateEmployeeSalary(Employee employee)
        {
            int EmployeeUpdatedAttendance = AttendanceManagmentSystem.Instance.GetEmployeeAttendance(employee.Id).GetEmployeeAttendanceAmount();
            if (EmployeeUpdatedAttendance == WorkingHours)
            {
                return SalaryAmount;
            }
            double EmployeeSalary = DefaultSallaryConstants.MINIMUM_HOURLY_WAGE * WorkingHours;
            List<IRole> Roles = RolesList.Instance.GetRolesForJob(employee.EmployeeJob);
            Roles.Where(x => x is IRoleHourlyWage).Select(Role => (IRoleHourlyWage)Role).ToList().ForEach(x => EmployeeSalary += x.CalculateRoleWage(EmployeeUpdatedAttendance));
            Roles.Where(x => x is IRoleMonthlyWage).Select(Role => (IRoleMonthlyWage)Role).ToList().ForEach(x => { EmployeeSalary += x.CalculateRoleWage(employee, EmployeeSalary); Console.WriteLine(x.Name); });
            this.SalaryAmount = EmployeeSalary;
            return EmployeeSalary;
        }
    }
}
