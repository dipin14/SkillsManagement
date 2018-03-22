using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common.Extensions
{
    public class ReportingStaffExtensions:IReportingStaffExtensions
    {

        private readonly Skillset_DAL.DTO.IReportingStaff _reportingStaff;
        public ReportingStaffExtensions(Skillset_DAL.DTO.IReportingStaff reportingStaff)
        {
            this._reportingStaff = reportingStaff;
        }

        public IEnumerable<ReportingStaff> GetEmployeeDetails(int managerCode)
        {
            var designations = _reportingStaff.GetDesignationDetails(managerCode);
            var staff= _reportingStaff.GetEmployeeDetails(managerCode);
            var staffDetails = (from s in staff
                               join d in designations on s.DesignationId equals d.Id
                               select new
                               {
                                   EmployeeCode = s.EmployeeCode,
                                   Name = s.Name,
                                   Email = s.Email,
                                   Designation = d.Name
                               }).Cast<ReportingStaff>().ToList();
            return staffDetails; 
        }
        public IEnumerable<StaffSkills> GetSkillRatingsDetails(string employeeCode)
        {
            var ratings = _reportingStaff.GetRatingDetails();
            var skills = _reportingStaff.GetSkillDetails();
            var skillRatings = _reportingStaff.GetSkillRatingsDetails(employeeCode);
            var skillRatingDetails = (from sr in skillRatings
                                      join r in ratings on sr.RatingId equals r.Id
                                      join s in skills on sr.SkillId equals s.skillId
                                select new
                                {
                                    Skill = s.skillName,
                                    Rating = r.Value,
                                    RatingDate = sr.RatingDate,
                                    Note = sr.Note
                                }).Cast<StaffSkills>().ToList();
            return skillRatingDetails;
        }
    }
}
