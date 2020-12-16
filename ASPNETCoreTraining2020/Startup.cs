using ASPNETCoreTraining2020.modul02;
using ASPNETCoreTraining2020.Pages.modul03;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Hosting.Server.Features;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.HttpsPolicy;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNETCoreTraining2020
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
            services.AddRazorPages();
            services.AddSingleton<Class1>();
            services.AddSingleton<MyCounter>();
            services.AddHttpContextAccessor();

        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env,ILogger<Startup> logger)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            AppDomain.CurrentDomain.SetData("ImgDir", env.WebRootPath);
            app.Use(async (context, next) =>
            {
               var srvFeatures=app.ServerFeatures.Get<IServerAddressesFeature>();
                string par= string.Join(":", srvFeatures.Addresses);
                logger.LogInformation("Webserver Ip/Port {0}", par);


                await next.Invoke();
            });


            app.UseHttpsRedirection();
            app.Map("/password.html", subapp =>
            {
                subapp.Use(async (context, next) =>
                {
                    context.Response.StatusCode = StatusCodes.Status403Forbidden;

                }
                    );
            });
            //app.Run(async (context) =>
            //{
            //    await context.Response.WriteAsync($"Hallo {CultureInfo.CurrentCulture.DisplayName}");
            //});


            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();


            app.UseEndpoints(endpoints =>
            {
                endpoints.MapRazorPages();
            });

        }
    }
}
