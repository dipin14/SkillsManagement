using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
   public interface IReportingStaffExtensions
    {
        IEnumerable<ReportingStaff> GetEmployeeDetails(int managerCode);
        IEnumerable<StaffSkills> GetSkillRatingsDetails(string employeeCode);
    }
}
