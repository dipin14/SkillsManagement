using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skillset_PL.Controllers
{
    public class EmployeeRatingController : Controller
    {
        private  IQuestion;
        public EmployeeRatingController()
        {

        }
        public EmployeeRatingController()
        {

        }
        // GET: EmployeeRating
        public ActionResult Index()
        {
            return View();
        }

     
        //Display all skills from the skill table
        public ActionResult AllSkills()
        {

            return View();
        }
    }
}
