using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Skillset_DAL.Models;
using Skillset_DAL.ContextClass;

namespace Skillset_DAL.Repositories
{
    public class LoginRepository : ILoginRepository
    {
        SkillsetDbContext db = new SkillsetDbContext();
        public bool CheckStatus(Login lg)
        {
            var status = (from log in db.Logins where (log.UserName == lg.UserName && log.Password == lg.Password) select log).Count()>0;

            if (status==true)
            {
                return true;
            }
            else
                return false;

        }

        public string GetRole(string username)
        {
            var designationId = (from employee in db.Employees where (username == employee.EmployeeCode) select (employee.DesignationId)).FirstOrDefault();
            var role = (from employee in db.Employees  join designation in db.Desinations on designationId equals designation.Id select (designation.Role)).FirstOrDefault();
            return role;
        }
    }
}
