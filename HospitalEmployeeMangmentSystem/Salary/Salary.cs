using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HospitalEmployeeMangmentSystem
{
    public class Salary : ISalary
    {
        public string Salary_EmployeeId { get; private set; }

        public double SalaryAmount { get; private set; } = 0;

        public int WorkingHours { get; private set; } = 0;

        public Salary(string EmployeeId)
        {
            this.Salary_EmployeeId = EmployeeId;
        }

        public double CalculateEmployeeSalary(Employee employee)
        {
            int EmployeeUpdatedAttendance = AttendanceManagmentSystem.Instance.GetEmployeeAttendance(employee.Id).GetEmployeeAttendanceAmount();
            if (EmployeeUpdatedAttendance == this.WorkingHours)
            {
                Console.WriteLine($"{employee.Name}'s Salary - ${this.SalaryAmount}, For {this.WorkingHours} Hours Worked");
                return SalaryAmount;
            }
            this.WorkingHours = EmployeeUpdatedAttendance;
            double EmployeeSalary = DefaultSallaryConstants.MINIMUM_HOURLY_WAGE * EmployeeUpdatedAttendance;
            List<IRole> Roles = RolesList.Instance.GetRolesForJob(employee.EmployeeJob);
            Roles.Where(x => x is IRoleHourlyWage).Select(Role => (IRoleHourlyWage)Role).ToList().ForEach(x => EmployeeSalary += x.CalculateRoleWage(EmployeeUpdatedAttendance));
            Roles.Where(x => x is IRoleMonthlyWage).Select(Role => (IRoleMonthlyWage)Role).ToList().ForEach(x => EmployeeSalary += x.CalculateRoleWage(employee, EmployeeSalary));
            this.SalaryAmount = EmployeeSalary;
            Console.WriteLine($"{employee.Name}'s Salary - ${EmployeeSalary}, For {WorkingHours} Hours Worked");
            return EmployeeSalary;
        }
    }
}
