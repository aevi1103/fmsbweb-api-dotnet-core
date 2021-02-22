using AutoMapper;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Newtonsoft.Json.Serialization;
using System;
using FmsbwebCoreApi.Context.Fmsb2;
using FmsbwebCoreApi.Context.Safety;
using FmsbwebCoreApi.Context.SAP;
using System.Linq;
using DateShiftLib.Helpers;
using DateShiftMethods.Helpers;
using FmsbwebCoreApi.Context.AutoGage;
using Microsoft.AspNetCore.Mvc.Formatters;
using FmsbwebCoreApi.Context.Intranet;
using FmsbwebCoreApi.Context.FmsbQuality;
using FmsbwebCoreApi.Context.Master;
using FmsbwebCoreApi.Context.FmsbMvc;
using FmsbwebCoreApi.Context.FmsbOee;
using FmsbwebCoreApi.Context.Iconics;
using FmsbwebCoreApi.Context.QualityCheckSheets;
using FmsbwebCoreApi.Entity.QualityCheckSheets;
using FmsbwebCoreApi.Hubs;
using FmsbwebCoreApi.Hubs.Counter;
using FmsbwebCoreApi.Hubs.Downtime;
using FmsbwebCoreApi.Hubs.DowntimeManual;
using FmsbwebCoreApi.Hubs.Scrap;
using Microsoft.AspNet.OData.Builder;
using Microsoft.AspNet.OData.Extensions;
using Microsoft.OData.Edm;
using Newtonsoft.Json;
using UtilityLibrary.Service;
using UtilityLibrary.Service.Interface;

namespace FmsbwebCoreApi
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        private const string MyAllowSpecificOrigins = "_myAllowSpecificOrigins";

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {

            services.AddCors(options =>
            {
                options.AddPolicy(MyAllowSpecificOrigins,
                builder =>
                {
                    builder.WithOrigins(
                        "http://10.129.224.149:82",
                        "http://10.129.224.149:84",
                        "http://10.129.224.149",
                        "http://localhost:58256",
                        "http://localhost:3000")
                    .AllowAnyHeader()
                    .AllowAnyMethod()
                    .AllowCredentials();

                });
            });

            services.AddMvc();

            //services.AddHttpCacheHeaders((expirationModelOptions) =>
            //{
            //    expirationModelOptions.MaxAge = 30;
            //    expirationModelOptions.CacheLocation = Marvin.Cache.Headers.CacheLocation.Private;
            //},
            //(validationModelOptions) =>
            //{
            //    validationModelOptions.MustRevalidate = true;
            //});

            services.AddResponseCaching(); //register http caching

            services.AddControllers(setupAction =>
                {
                    //content negotiation
                    setupAction.ReturnHttpNotAcceptable = true; //return a 406 error in client if the acceptable header is not supported
                    setupAction.CacheProfiles.Add("240SecCacheProfile", new CacheProfile { Duration = 240 });
                })
                .AddNewtonsoftJson(setupAction =>
                {
                    setupAction.SerializerSettings.ContractResolver = new CamelCasePropertyNamesContractResolver(); //enabled patch format in .net core
                    setupAction.SerializerSettings.ReferenceLoopHandling = ReferenceLoopHandling.Ignore;
                })
                .AddXmlDataContractSerializerFormatters(); //support xml input/output formatter 

            services.AddOData(); // register odata

            //add support of custom accept header
            services.Configure<MvcOptions>(config =>
            {
                var newtonsoftOutputFormatter = config.OutputFormatters.OfType<NewtonsoftJsonOutputFormatter>()?.FirstOrDefault();
                //newtonsoftOutputFormatter?.SupportedMediaTypes.Add("application/vnd.fmsbweb.hateoas+json");
            });

            //register safety property mapping service
            services.AddTransient<Services.Safety.IPropertyMappingService, Services.Safety.PropertyMappingService>();

            //register property checker service
            services.AddTransient<Services.IPropertyCheckerService, Services.PropertyCheckerService>();

            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

            //inject repositories
            services.AddScoped<Repositories.Interfaces.IScrapRepository, Repositories.ScrapRepository>();
            services.AddScoped<Repositories.Interfaces.IProductionRepository, Repositories.ProductionRepository>();
            services.AddScoped<Repositories.Interfaces.IKpiTargetRepository, Repositories.KpiTargetRepository>();
            services.AddScoped<Repositories.Interfaces.IEndOfShiftReportRepository, Repositories.EndOfShiftReportRepository>();
            services.AddScoped<Repositories.Interfaces.IMachineMappingRepository, Repositories.MachineMappingRepository>();
            services.AddScoped<Repositories.Interfaces.IAutoGageRepository, Repositories.AutoGageRepository>();
            services.AddScoped<Repositories.Interfaces.ILogisticsRepository, Repositories.LogisticsRepository>();
            services.AddScoped<Repositories.Interfaces.IDowntimeRepository, Repositories.DowntimeRepository>();
            services.AddScoped<Repositories.Interfaces.IProjectTrackerRepository, Repositories.ProjectTrackerRepository>();
            services.AddScoped<Repositories.Interfaces.IMaintenanceAlertRepository, Repositories.MaintenanceAlertRepository>();

            services.AddScoped<Repositories.Interfaces.QualityCheckSheets.ICharacteristicRepository, Repositories.QualityCheckSheets.CharacteristicRepository>();
            services.AddScoped<Repositories.Interfaces.QualityCheckSheets.IMachineRepository, Repositories.QualityCheckSheets.MachineRepository>();
            services.AddScoped<Repositories.Interfaces.QualityCheckSheets.IOrganizationPartRepository, Repositories.QualityCheckSheets.OrganizationPartRepository>();
            services.AddScoped<Repositories.Interfaces.QualityCheckSheets.ISubMachineRepository, Repositories.QualityCheckSheets.SubMachineRepository>();
            services.AddScoped<Repositories.Interfaces.QualityCheckSheets.IReCheckRepository, Repositories.QualityCheckSheets.ReCheckRepository>();

            //inject services
            services.AddScoped<Services.Interfaces.ISapLibraryService, Services.SapLibraryService>();
            services.AddScoped<Services.Interfaces.IScrapService, Services.ScrapService>();
            services.AddScoped<Services.Interfaces.IProductionService, Services.ProductionService>();
            services.AddScoped<Services.Interfaces.IKpiTargetService, Services.KpiTargetService>();
            services.AddScoped<Services.Interfaces.IKpiService, Services.KpiService>();
            services.AddScoped<Services.Interfaces.IUtilityService, Services.UtilityService>();
            services.AddScoped<Services.Interfaces.IDataAccessUtilityService, Services.DataAccessUtilityService>();
            services.AddScoped<Services.Interfaces.IEndOfShiftReportService, Services.EndOFShiftReportService>();
            services.AddScoped<Services.Interfaces.IExportService, Services.ExportService>();
            services.AddScoped<Services.Interfaces.ISwotService, Services.SwotService>();
            services.AddScoped<Services.Interfaces.ILogisticsService, Services.LogisticsService>();
            services.AddScoped<Services.Interfaces.IOeeService, Services.OeeService>();
            services.AddScoped<Services.Interfaces.IProjectTrackerService, Services.ProjectTrackerService>();
            services.AddScoped<Services.Interfaces.IMaintenanceAlertService, Services.MaintenanceAlertService>();

            services.AddScoped<Services.Interfaces.QualityCheckSheets.ICharacteristicService, Services.QualityCheckSheets.CharacteristicService>();
            services.AddScoped<Services.Interfaces.QualityCheckSheets.IMachineService, Services.QualityCheckSheets.MachineService>();
            services.AddScoped<Services.Interfaces.QualityCheckSheets.IOrganizationPartService, Services.QualityCheckSheets.OrganizationPartService>();
            services.AddScoped<Services.Interfaces.QualityCheckSheets.ISubMachineService, Services.QualityCheckSheets.SubMachineService>();
            services.AddScoped<Services.Interfaces.QualityCheckSheets.ICheckSheetService, Services.QualityCheckSheets.CheckSheetService>();
            services.AddScoped<Services.Interfaces.QualityCheckSheets.ICheckSheetEntryService, Services.QualityCheckSheets.CheckSheetEntryService>();
            services.AddScoped<Services.Interfaces.QualityCheckSheets.IReCheckService, Services.QualityCheckSheets.ReChecksService>();

            services.AddScoped<Services.Safety.ISafetyLibraryRepository, Services.Safety.SafetyLibraryRepository>();
            services.AddScoped<Services.Logistics.ILogisticsLibraryRepository, Services.Logistics.LogisticsLibraryRepository>();
            services.AddScoped<Services.FMSB2.IFmsb2LibraryRepository, Services.FMSB2.FmsbLibraryRepository>();
            services.AddScoped<Services.Intranet.IIntranetLibraryRepository, Services.Intranet.IntranetLibraryRepository>();
            services.AddScoped<Services.FmsbQuality.IFmsbQualityLibraryRepository, Services.FmsbQuality.FmsbQualityLibraryRepository>();
            services.AddScoped<Services.FmsbMvc.IFmsbMvcLibraryRepository, Services.FmsbMvc.FmsbMvcLibraryRepository>();
            services.AddScoped<Services.Iconics.IIconicsLibraryRepository, Services.Iconics.IconicsLibraryRepository>();

            //external class lib
            services.AddScoped<IConverterService, ConverterService>();
            services.AddScoped<IEmailService, EmailService>();
            services.AddScoped<IStringUtilityService, StringUtilityService>();
            services.AddScoped<Hour, Hour>();
            services.AddScoped<DateShift, DateShift>();

            //inject connection strings
            services.AddDbContext<Fmsb2Context>(options => options.UseSqlServer(Configuration.GetConnectionString("fmsbConn")));
            services.AddDbContext<IconicsContext>(options =>  options.UseSqlServer(Configuration.GetConnectionString("iconicsConn")));
            services.AddDbContext<FmsbMvcContext>(options => options.UseSqlServer(Configuration.GetConnectionString("fmsbMvc")));
            services.AddDbContext<SafetyContext>(options => options.UseSqlServer(Configuration.GetConnectionString("safetyConn")));
            services.AddDbContext<SapContext>(options => options.UseSqlServer(Configuration.GetConnectionString("sapConn"), sqlServerOptions => sqlServerOptions.CommandTimeout(60)));
            services.AddDbContext<IntranetContext>(options => options.UseSqlServer(Configuration.GetConnectionString("intranet")));
            services.AddDbContext<fmsbQualityContext>(options => options.UseSqlServer(Configuration.GetConnectionString("fmsbQuality")));
            services.AddDbContext<masterContext>(options => options.UseSqlServer(Configuration.GetConnectionString("fmoMaster")));
            services.AddDbContext<QualityCheckSheetsContext>(options => options.UseSqlServer(Configuration.GetConnectionString("qualityCheckSheetsConn")));
            services.AddDbContext<AutoGageContext>(options => options.UseSqlServer(Configuration.GetConnectionString("autoGageConn")));
            services.AddDbContext<FmsbOeeContext>(options => options.UseSqlServer(Configuration.GetConnectionString("fmsbOeeConn")));

            //signal r
            services.AddSignalR();

            // inject singleton instance for hub tickers
            services.AddSingleton<CounterTicker>();
            services.AddSingleton<DowntimeTicker>();
            //services.AddSingleton<DowntimeManualTicker>();
            services.AddSingleton<ScrapTicker>();

            // Register the Swagger generator, defining 1 or more Swagger documents
            services.AddSwaggerGen();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler(appBuilder =>
                {

                    appBuilder.Run(async context =>
                    {
                        context.Response.StatusCode = 500;
                        await context.Response.WriteAsync("An unexpected fault happened. Try again later.").ConfigureAwait(false);
                    });

                });
            }

            //if we want to implement Etag validation comment 'app.UseResponseCaching()'
            //then on the client side request header add a 'If-None-Match' with the latest E-Tag generated' if the E tag does not
            //match from the current E-tag generated it will it will hit the API
            //else it will response a '304 not-modified'

            //if we want to implement concurrency
            //on the client side request header add 'If-Match' with the client current 'E-tag' generated from the latest 'GET' request
            //if the client does not have the latest E-Tag it will response with '412 precondition failed'

            //app.UseResponseCaching(); //use caching store middleware
            app.UseHttpsRedirection();
            app.UseRouting();
            app.UseCors(MyAllowSpecificOrigins);
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                //endpoints.SetTimeZoneInfo(TimeZoneInfo.Utc);
                endpoints.MapControllers();
                //endpoints.MapODataRoute("odata", "odata", GetEdmModel()); //uncomment this if you want to use odata models instead, the comment endpoints.EnableDependencyInjection();
                endpoints.EnableDependencyInjection();
                endpoints.Select().Filter().OrderBy().Count().MaxTop(null).Expand();

                endpoints.MapHub<ChatHub>("/chathub");
                endpoints.MapHub<CounterHub>("/counterhub");
                endpoints.MapHub<DowntimeHub>("/downtimehub");
                //endpoints.MapHub<DowntimeManualHub>("/downtimemanualhub");
                endpoints.MapHub<ScrapHub>("/scraphub");
            });

        }

        private static IEdmModel GetEdmModel()
        {
            var odataBuilder = new ODataConventionModelBuilder();
            odataBuilder.EntitySet<Machine>("Machines");
            odataBuilder.EntitySet<Line>("Lines");
            return odataBuilder.GetEdmModel();
        }
    }
}
