using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Veterinaria.Clase;

namespace Veterinaria
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            this.CheckRoles();
            Utilities.CheckSuperUser();
            BundleConfig.RegisterBundles(BundleTable.Bundles);
        }

        private void CheckRoles()
        {
            Utilities.CheckRoles("Admin");
            Utilities.CheckRoles("Owner");
            Utilities.CheckRoles("Veterinarian");
        }
    }
}
