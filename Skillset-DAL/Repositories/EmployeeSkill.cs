using Skillset_DAL.ContextClass;
using Skillset_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_DAL.Repositories
{
    public class EmployeeSkill
    {
        private SkillsetDbContext context;

        //injection through constructor  
        public EmployeeSkill(SkillsetDbContext context)
        {
            this.context = context;
        }

        public IEnumerable<Employee> GetEmployeeDetails(string option, string searchKey)
        {
            if(option=="Employee Code")
            {
                return context.Employees.Where(m => m.Status==true && m.EmployeeCode.Contains(searchKey)).Select(m => m).ToList();
            }
            else if(option=="Name")
            {
                return context.Employees.Where(m => m.Status == true && m.Name.Contains(searchKey)).Select(m => m).ToList();
            }
        }

        public IEnumerable<Designation> GetDesignationDetails(string option, string searchKey)
        {
            if (option == "Employee Code")
            {

            }
            else if (option == "Name")
            {

            }
            else if (option == "Designation")
            {

            }
        }
    }
}
