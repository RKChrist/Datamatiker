using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace ExploreCalifornia
{
    public class Startup
    {
        private readonly IConfiguration configuration;

        public Startup(IConfiguration configuration)
        {
            this.configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddTransient(x => new FeatureToggles
            {
                DeveloperExtensions = configuration.GetValue<bool>("FeatureToggles:EnableDeveloperExceptions")
            });
            //To configure mvc, we use this method, which adds mvc services to the IServiceCollection
            services.AddMvc();
        }
        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, 
            IHostingEnvironment env,
            FeatureToggles feature
            )
        {
            
            if (feature.DeveloperExtensions)
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error.html");
                
            }


            //creating error (The basics (Error handling and diagnostics)
            app.Use(async (context, next) =>
            {
                if (context.Request.Path.Value.Contains("invalid"))
                {
                    throw new ArgumentException("ERROR");
                }
                await next();   
                
            });

            //Adds MVC methods to the IApplicationBuilder request execution pipeline, which builds the application using the MVC pattern.
            app.UseMvc(routes => 
            {
                routes.MapRoute("Default", "{controller=Home}/{action=Index}/{id?}");
            });

           
            app.UseFileServer();


            //First Exercise
            //OLD 
            //Use is to aynsc use that lamda expression before app.run
            // Hvis du vil bruge next.Invoke(), så kommer den efter din run method, selvom din run method terminator din pipeline.
                    //app.Use(async (context, next) =>
                    //{
                    //    //if (context.Request.Path.Value.StartsWith("/Hello"))
                    //    //{
                    //    //    await context.Response.WriteAsync("Bitch");
                    //    //}
                    //    await next.Invoke();

                    //    await context.Response.WriteAsync("Hello from 1nd Delegate");
                    //});
          
                    //app.Run(async (context) =>
                    //{
                    //    await context.Response.WriteAsync("Hello from 2nd Delegate");
                    //});


        }
    }
}
