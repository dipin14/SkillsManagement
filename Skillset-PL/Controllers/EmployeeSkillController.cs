using Skillset_BLL.Services;
using Common.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Skillset_PL.ViewModels;

namespace Skillset_PL.Controllers
{
    public class EmployeeSkillController : Controller
    {
        private IEmployeeSkillService objEmpSkill;

        //injection through constructor  
        public EmployeeSkillController(IEmployeeSkillService tmpService)
        {
            objEmpSkill = tmpService;
        }

        public ActionResult Index()
        {
            if ((designationSearch == "Select one") && (employeeNameSearch == null))
            {
                designationSearch = null;
            }
            else if ((designationSearch == "Select one") && (employeeNameSearch == string.Empty))
            {
                designationSearch = string.Empty;
            }
            else if (designationSearch == "Select one")
            {
                designationSearch = string.Empty;
            }
            IEnumerable<AdminEmployeeDto> employeerecordlist;
            //calling method to search for employee details
            employeerecordlist = objEmpSkill.ViewSearchedRecords(employeeCodeSearch, employeeNameSearch, designationSearch;

            List<AdministratorEmployeeViewModel> recordlist = new List<AdministratorEmployeeViewModel>();

            foreach (var obj in employeerecordlist)
            {
                recordlist.Add(new AdministratorEmployeeViewModel(obj.EmployeeCode,obj.Name,obj.Designation));
            }
            return View(recordlist);
        }
    }
}