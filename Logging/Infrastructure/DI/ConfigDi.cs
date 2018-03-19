using Autofac;
using System.Web.Mvc;
using Autofac.Integration.Mvc;
using SimpleLogging.Core;
using SimpleLogging.NLog;

namespace Logging.Infrastructure.DI
{
   public class ConfigDi
   {
      public static void Setup()
      {
         var builder = new ContainerBuilder();

         builder.RegisterControllers(typeof(MvcApplication).Assembly);

         builder.Register(c => new NLogLoggingService())
         .As<ILoggingService>();

         var container = builder.Build();

         DependencyResolver.SetResolver(new AutofacDependencyResolver(container));
      }
   }
}