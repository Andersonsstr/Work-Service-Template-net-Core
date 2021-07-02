using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Work_Service_Template_net_Core
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
           Host.CreateDefaultBuilder(args)
               .UseWindowsService()
               .ConfigureServices((hostContext, services) =>
               {
                   services.AddHostedService<Worker>();
                   System.Threading.Thread.CurrentThread.CurrentCulture = new CultureInfo("pt-BR");
                   System.Threading.Thread.CurrentThread.CurrentUICulture = new CultureInfo("pt-BR");
               });
    }
}
