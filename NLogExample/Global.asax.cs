using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Logging.Infrastructure.DI;
using NLog;

namespace Logging
{
   public class MvcApplication : System.Web.HttpApplication
   {
      protected void Application_Start()
      {
         ConfigDi.Setup();
         AreaRegistration.RegisterAllAreas();
         FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
         RouteConfig.RegisterRoutes(RouteTable.Routes);
         BundleConfig.RegisterBundles(BundleTable.Bundles);
      }

   }
}
