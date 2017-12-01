using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using BasicTestApp.Sales.Services;
using BasicTestApp.Data;
using BasicTestApp.DataStore;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace BasicTestApp.Api
{
    public class Startup
    {
        public const string LOCAL_ENVIROMENT = "Local";

        public ILogger<Startup> _logger;
        private IConfiguration _configuration;

        public Startup(IHostingEnvironment env, ILogger<Startup> logger, IConfiguration configuration)
        {
            _logger = logger;
            _configuration = configuration;
        }

        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            //Services
            services.AddScoped<IAccountService, AccountService>();

            //Data
            services.AddDbContext<BasicTestAppDbContext>(
                options => options.UseSqlServer(_configuration.GetConnectionString("DefaultConnection")));
            services.AddScoped<IAccountData, SqlAccountData>();

            services.AddMvc();

            services.AddAutoMapper(typeof(MappingProfile), typeof(SqlDataMappingProfile));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app,
                              IHostingEnvironment env,
                              IConfiguration configuration)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseWelcomePage(new WelcomePageOptions() { Path = "/Welcome" });

            app.UseStaticFiles();

            app.UseMvcWithDefaultRoute();

            app.Run(async (context) =>
            {
                await context.Response.WriteAsync($"Enviroment : {env.EnvironmentName}");
            });
        }
    }
}
