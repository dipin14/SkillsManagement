using Common.DTO;
using Skillset_DAL.Models;
using Skillset_DAL.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Skillset_BLL.Services
{
    public class EmployeeSkillService
    {
        private IEmployeeSkill objEmpSkill;

        //injection through constructor  
        public EmployeeSkillService(IEmployeeSkill tmpService)
        {
            objEmpSkill = tmpService;
        }

        public IEnumerable<AdminEmployeeDto> ViewSearchedRecords(string option,string searchKey)
        {
            List<Employee> employeeList = objEmpSkill.GetEmployeeDetails(option,searchKey);
            List<Designation> designationList = objEmpSkill.GetDesignationDetails(option, searchKey);
        }
    }
}
