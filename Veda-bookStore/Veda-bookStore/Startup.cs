using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Veda_bookStore
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.Use(async (context, next) =>
            //{
            //    await context.Response.WriteAsync("hello from first middle ware 1 ");

            //    await next();

            //    await context.Response.WriteAsync("hello from first middle ware  response 3 ");

            //});

            //app.Use(async ( context,next) =>
            //{
            //    await context.Response.WriteAsync("hello from Second  middle ware 2 ");
            //});

            app.UseRouting();

       
            app.UseEndpoints(endpoints =>
            {
                endpoints.Map("/", async context =>
                {
                    if (env.IsEnvironment("Develop"))
                    {
                        await context.Response.WriteAsync("Hello World! DEV");
                    }
                    else
                    {
                        await context.Response.WriteAsync(env.EnvironmentName);
                    }

                });
            });
            //app.UseEndpoints(endpoints =>
            //{
            //    endpoints.Map("/veda", async context =>
            //    {
            //        await context.Response.WriteAsync("Hello World!-veda");
            //    });
            //});
        }
    }
}
