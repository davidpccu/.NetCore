using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterM
{
    public class Startup
    {
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            // 開發環境 / 線上環境 設定
            env.EnvironmentName = Environments.Production;

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseStatusCodePages();
            }
            else
            {
                app.UseExceptionHandler("/error");
                //app.UseStatusCodePages("text/html","<h1>status code:{0}</h1>");
                //app.UseStatusCodePagesWithRedirects("/StatusCode?code={0}");
                //app.UseStatusCodePagesWithReExecute("/StatusCode", "?code={0}");
            }

            app.UseStaticFiles(); //WebRoott靜態檔案(wwwroot)
            app.UseRouting();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute("default", 
                    "{controller=home}/{action=index}/{id?}");
            });
        }
    }
}
