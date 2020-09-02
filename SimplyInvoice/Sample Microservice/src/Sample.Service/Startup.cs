using Sample.RP.RestApi.Configuration;
using Sample.RP.RestApi.HealthChecks;
using IdentityServer4.AccessTokenValidation;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Diagnostics.HealthChecks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.OpenApi.Models;
using Serilog;
using Swashbuckle.AspNetCore.SwaggerGen;
using System;
using System.Linq;
using System.Reflection;
using Sample.Service.Core.Sql;
using Sample.Service.Services.Case;

namespace Sample.RP.RestApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
           

            services.AddControllers();

            services.AddControllers(options =>
            {
                options.Filters.Add<UnhandledExceptionFilter>();
            });

            services.AddApiVersioning(options =>
            {
                options.ReportApiVersions = true;
                options.RegisterMiddleware = true;
            })
            .AddVersionedApiExplorer(options => { options.SubstituteApiVersionInUrl = true; });
            services.AddMvcCore();

            services.AddHttpContextAccessor();

            services.AddCors(c =>
            {
                c.AddPolicy("AllowOrigin", options => options.AllowAnyOrigin());
            });

            services.AddSingleton<HealthCheckStatusData>();
            services.AddHealthChecks()
                .AddCheck<LivenessHealthCheck>("Liveness")
                .AddCheck<ReadinessHealthCheck>("Readiness");

            services.Configure<SqlConnectionFactoryOptions>(options =>
            {
                options.ConnectionString = Configuration.GetConnectionString("CaseManagementDb");
            });

            services.AddSingleton<ISqlConnectionFactory, SqlConnectionFactory>();
            services.AddTransient<ICaseService, CaseService>();


        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHealthChecks("/", new HealthCheckOptions { Predicate = check => check.Name == "Liveness" });
            app.UseHealthChecks("/ping", new HealthCheckOptions { Predicate = check => check.Name == "Liveness" });
            app.UseHealthChecks("/live", new HealthCheckOptions { Predicate = check => check.Name == "Liveness" });
            app.UseHealthChecks("/ready", new HealthCheckOptions { Predicate = check => check.Name == "Readiness" });

            app.UseSerilogRequestLogging();

            app.UseCors(builder => builder
                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader());


            app.UseRouting();
            app.UseHsts();

            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
