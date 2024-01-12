using EPiServer.Cms.Shell;
using EPiServer.Cms.UI.AspNetIdentity;
using EPiServer.ContentApi.Core.DependencyInjection;
using EPiServer.DependencyInjection;
using EPiServer.Scheduler;
using EPiServer.ServiceLocation;
using EPiServer.Web.Routing;
using Optimizely.ContentGraph.Cms.Configuration;

namespace Dexred.OptimizelySaas
{
    public class Startup
    {
        private readonly IWebHostEnvironment _webHostingEnvironment;
        private readonly IConfiguration _configuration;

        public Startup(IWebHostEnvironment webHostingEnvironment, IConfiguration configuration)
        {
            _webHostingEnvironment = webHostingEnvironment;
            _configuration = configuration; 
        }

        public void ConfigureServices(IServiceCollection services)
        {
            if (_webHostingEnvironment.IsDevelopment())
            {
                AppDomain.CurrentDomain.SetData("DataDirectory", Path.Combine(_webHostingEnvironment.ContentRootPath, "App_Data"));

                services.Configure<SchedulerOptions>(options => options.Enabled = false);
            }

            services.ConfigureForExternalTemplates();
            services.Configure<ExternalApplicationOptions>(options => options.OptimizeForDelivery = true);
            services
                .AddCmsAspNetIdentity<ApplicationUser>()
                .AddCms()
                .AddAdminUserRegistration()
                .AddEmbeddedLocalization<Startup>();
            services.ConfigureContentApiOptions(o =>
            {
                o.IncludeInternalContentRoots = true;
                o.IncludeSiteHosts = true;
            });
            services.AddContentDeliveryApi();
            services.AddContentGraph();
            services.AddContentGraph(options =>
            {
                options.EnablePreviewTokens = true;

                options.Events.OnGeneratingPreviewUrl = ctx =>
                {
                    // ctx.UpdateUrl(new Uri("/test?id=" + ctx.ContentReference, UriKind.RelativeOrAbsolute));
                    return Task.CompletedTask;
                };
            });
            services.Configure<EventIndexingOptions>(ops =>
            {
                ops.SyncContentTypesOnInit = true;
            });
        }

        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseStaticFiles();
            //app.UseCors(b => b
            //.WithOrigins(new[] { $"{_frontendUri}" })
            app.UseCors(builder =>
            {
                builder.WithOrigins(_configuration.GetValue<string>("FRONT_END_URL"))
                       .AllowAnyHeader()
                       .AllowAnyMethod();
            });
            app.UseRouting();
            app.UseAuthentication();
            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapContent();
            });
        }
    }
}