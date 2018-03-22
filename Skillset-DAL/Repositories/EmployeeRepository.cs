﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillset_DAL.Models;
using Skillset_DAL.ContextClass;

namespace Skillset_DAL.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        public int AddEmployee(Employee employee)
        {
            var employeeList = new List<Employee>();
            using (SkillsetDbContext context = new SkillsetDbContext())
            {
                employeeList = context.Employees.ToList();
                int status = CheckDuplicateEmployee(employeeList, employee);
                if (status == 0)
                {
                    context.Employees.Add(employee);
                    context.SaveChanges();
                    return 0;
                }
                else
                {
                    return status;
                }
            }
        }

        public int CheckDuplicateEmployee(List<Employee> employeeList, Employee newEmployee)
        {
            var check = new List<Employee>();
            check = employeeList.Where(p => p.EmployeeCode == newEmployee.EmployeeCode).ToList();
            if (check.Count != 0)
            {
                return 1;
            }
            check = employeeList.Where(p => p.MobileNumber == newEmployee.MobileNumber).ToList();
            if (check.Count != 0)
            {
                return 2;
            }
            check = employeeList.Where(p => p.Email == newEmployee.Email).ToList();
            if (check.Count != 0)
            {
                return 3;
            }
            return 0;

        }

        public int DeleteEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public Employee EditEmployee(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Employee> GetAllEmployees()
        {
            throw new NotImplementedException();
        }

        public List<Designation> GetDesignations()
        {
            using (SkillsetDbContext context = new SkillsetDbContext())
            {
                return context.Designations.ToList();
            }
        }

        public Employee GetEmployeeDetails(int id)
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetManagers()
        {
            using (SkillsetDbContext context = new SkillsetDbContext())
            {
               return context.Employees.ToList();
            }
        }

        public List<Qualification> GetQualifications()
        {
            using (SkillsetDbContext context = new SkillsetDbContext())
            {
              return context.Qualifications.ToList();
            }
        }
    }
}