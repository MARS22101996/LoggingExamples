using System;
using System.Web.Mvc;
using NLog;
using SimpleLogging.Core;

namespace Logging.Controllers
{
   public class HomeController : Controller
   {
      private readonly ILoggingService _logger;

      public HomeController(ILoggingService logger)
      {
         _logger = logger;
      }

      public ActionResult Index()
      {
         _logger.Trace("Sample trace message");
         _logger.Debug("Sample debug message");
         _logger.Info("Sample informational message");
         _logger.Warning("Sample warning message");

         try
         {
            throw new ArgumentNullException();
         }
         catch (Exception e)
         {
            _logger.Error(e, "Sample error message");
         }

         return View();
      }

      public ActionResult About()
      {
         ViewBag.Message = "Your application description page.";

         return View();
      }

      public ActionResult Contact()
      {
         ViewBag.Message = "Your contact page.";

         return View();
      }
   }
}