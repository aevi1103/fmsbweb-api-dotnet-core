using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using Microsoft.EntityFrameworkCore;

using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Safety;
using FmsbwebCoreApi.Context.SAP;

using FmsbwebCoreApi.Services.Safety;
using Microsoft.AspNetCore.Mvc.Formatters;

namespace FmsbwebCoreApi
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
            services.AddControllers(setupAction => {
                setupAction.ReturnHttpNotAcceptable = true; //return a 406 error in client if the acceptable header is not supported
            })
            .AddXmlDataContractSerializerFormatters(); //support xml output formatter

            //inject safety repo
            services.AddScoped<ISafetyLibraryRepository, SafetyLibraryRepository>(); 

            //inject connection strings
            services.AddDbContext<Fmsb2Context>(options =>
                options.UseSqlServer(Configuration.GetConnectionString("fmsbConn")));

            services.AddDbContext<SafetyContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("safetyConn")));

            services.AddDbContext<SapContext>(options =>
               options.UseSqlServer(Configuration.GetConnectionString("sapConn")));
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

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
