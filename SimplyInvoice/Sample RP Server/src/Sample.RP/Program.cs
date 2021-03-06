using Sample.RP.RestApi.Extensions;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;
using System;

namespace Sample.RP.RestApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AppContext.SetSwitch("System.Net.Http.SocketsHttpHandler.Http2UnencryptedSupport", true);

            Log.Logger = new LoggerConfiguration().WithDefaults().CreateLogger();

            try
            {
                Log.Logger.ForContext<Program>().Information("Starting");
                var host = CreateHostBuilder(args).Build();
                host.Run();
                Log.Logger.ForContext<Program>().Information("Stopping");
            }
            catch (Exception e)
            {
                Log.Logger.ForContext<Program>().Fatal(e, "Host terminated unexpectedly");
            }
            finally
            {
                Log.CloseAndFlush();
            }
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .UseSerilog()
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });
    }
}
