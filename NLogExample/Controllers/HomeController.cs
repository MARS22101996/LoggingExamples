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
         _logger.Debug("Sample debug message");
         _logger.Info("Sample informational message");
         _logger.Warning("Sample warning message");

         try
         {
            throw new ArgumentNullException();
         }
         catch (Exception ex)
         {
            _logger.Error(ex, $"Operation failed due to error: {ex.Message}");
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