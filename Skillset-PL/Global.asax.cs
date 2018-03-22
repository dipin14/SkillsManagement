using Autofac;
using Autofac.Integration.Mvc;
using Common.Extensions;
using Skillset_DAL.ContextClass;
using Skillset_DAL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace Skillset_PL
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            RegisterAutofac();
        }

        private void RegisterAutofac()
        {
            var builder = new ContainerBuilder();
            builder.RegisterControllers(Assembly.GetExecutingAssembly());
            builder.RegisterSource(new ViewRegistrationSource());

            // manual registration of types;
            builder.RegisterType<ReportingStaff>().As<IReportingStaff>();
            builder.RegisterType<ReportingStaffExtensions>().As<IReportingStaffExtensions>();
            builder.RegisterType<SkillsetDbContext>();
            
            var container = builder.Build();
            DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
        }
    }
}
