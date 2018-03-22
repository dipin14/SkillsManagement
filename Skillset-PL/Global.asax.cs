using Skillset_DAL.ContextClass;
using Skillset_BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Autofac;
using System.Reflection;
using Autofac.Integration.Mvc;
using Skillset_DAL.Repositories;

namespace Skillset_PL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterSource(new ViewRegistrationSource());
            builder.RegisterType<EmployeeSkillService>().As<IEmployeeSkillService>();
            builder.RegisterType<EmployeeSkill>().As<IEmployeeSkill>();
            builder.RegisterType<SkillsetDbContext>();
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
