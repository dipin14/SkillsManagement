using Skillset_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_DAL.DTO
{
   public interface IReportingStaff
    {
        IEnumerable<Employee> GetEmployeeDetails(int managerCode);
        IEnumerable<SkillRating> GetSkillRatingsDetails(string employeeCode);
        IEnumerable<Designation> GetDesignationDetails(int managerCode);
        IEnumerable<Skill> GetSkillDetails();
        IEnumerable<Rating> GetRatingDetails();
    }
}
