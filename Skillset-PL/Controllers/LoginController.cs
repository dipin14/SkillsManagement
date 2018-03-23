using Common.DTO;
using Skillset_BLL.Services;
using Skillset_PL.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Skillset_PL.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILoginService logService;
        public LoginController()
        {

        }
        public LoginController(ILoginService logSer)
        {
            logService = logSer;
        }
        // GET: Login
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Login(LoginViewModel log)
        {
            LoginDTO lg = new LoginDTO
            {
                Password = log.Password,
                UserName = log.UserName
            };
            var status = logService.CheckStatus(lg);
            if(status==true)
            {
                var role = logService.GetRole(log.UserName);
                if(role=="Admin")
                {
                    return RedirectToAction("Index");
                }
                else if(role=="Manager")
                {
                    return RedirectToAction("Search");
                }
                else
                {
                    return RedirectToAction("Search");
                }
            }
            else
            return View(log);
        }
    }
}