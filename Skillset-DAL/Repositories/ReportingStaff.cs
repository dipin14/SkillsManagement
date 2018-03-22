using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillset_DAL.Models;
using Skillset_DAL.ContextClass;

namespace Skillset_DAL.DTO
{
    public class ReportingStaff : IReportingStaff
    {
       public IEnumerable<Designation> GetDesignationDetails(int managerCode)
        {
            using (SkillsetDbContext context = new SkillsetDbContext())
            {
                var designations = (from d in context.Designations
                                    from e in context.Employees
                                    where (e.ManagerCode == managerCode && d.Id == e.DesignationId)
                                    select d).ToList();
                                  
                return designations;
            }
                
        }

        public IEnumerable<Employee> GetEmployeeDetails(int managerCode)
        {
            using (SkillsetDbContext context = new SkillsetDbContext())
            {
                var employees = context.Employees.ToList().Where(s => s.ManagerCode==managerCode);
                return employees;
            }
            
        }

        public IEnumerable<SkillRating> GetSkillDetails(int managerCode)
        {
            using (SkillsetDbContext context = new SkillsetDbContext())
            {
                var skills = (from d in context.SkillRatings
                              from e in context.Employees
                              where (e.ManagerCode == managerCode && d.EmployeeId==e.Id)
                              select d).ToList();
                return skills;
            }
           
        }
    }
}
