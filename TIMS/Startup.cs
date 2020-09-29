using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using TIMS.Context;
using TIMS.Service.Implements;
using TIMS.Service.Interfaces;

namespace TIMS
{
    public class Startup
    {
        readonly string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";
        public Startup(IConfiguration configuration)
        {
            
            Configuration = configuration;

            GlobalVariables.EnvironmentType = configuration.GetSection(Const.Startup.DeploymentEnvironment).Value;
            Configuration = new ConfigurationBuilder()
                .SetBasePath(configuration.GetSection(Const.Startup.ContentRoot).Value)
                .AddJsonFile(Const.Startup.AppSettingsJson, false, true)
                .AddJsonFile($"appsettings.{GlobalVariables.EnvironmentType}.json", true, true)
                .AddEnvironmentVariables().Build();

            GlobalVariables.ConnectionStringMainDatabase = Configuration.GetConnectionString(Const.Startup.DefaultConnection);
         
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddDbContext<ApplicationContext>(options =>
                options.UseSqlServer(GlobalVariables.ConnectionStringMainDatabase
                ));

            services.AddTransient<ISaleService, SaleService>();

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:4200")
                            .AllowAnyHeader()
                            .AllowAnyMethod();
                        // .WithMethods("GET", "POST", "DELETE", "PUT"); // .AllowAnyOrigin();
                    });
            });

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            app.UseCors(MyAllowSpecificOrigins);
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
