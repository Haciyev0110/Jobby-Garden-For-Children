using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using JobbyGarden.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.FileProviders;
using System.IO;

namespace JobbyGarden
{
    public class Startup
    {
        private IConfiguration Configuration;

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }
        // This method gets called by the runtime. Use this method to add services to the container.
        // For more information on how to configure your application, visit https://go.microsoft.com/fwlink/?LinkID=398940
        public void ConfigureServices(IServiceCollection services)
        {
            
            services.AddDbContext<JobbyContext>(options => options.UseSqlServer(Configuration["Database:JobDbb"]));

            services.AddIdentity<User, IdentityRole>(x=>
            {
                x.Password.RequireUppercase = false;
                x.Password.RequireNonAlphanumeric = false;
                x.Password.RequireLowercase = false;
                x.Password.RequireDigit = false;

                x.Lockout.MaxFailedAccessAttempts = 5;
                
            })
                .AddDefaultTokenProviders()
                .AddEntityFrameworkStores<JobbyContext>();

            services.ConfigureApplicationCookie(option => {

                option.LoginPath = new PathString("/AccountUser/AccountIndex");
                option.AccessDeniedPath = new PathString("/AccountUser/AccountIndex");

            });

            services.AddMvc();
            services.AddMvc().AddJsonOptions(options => { options.SerializerSettings.ReferenceLoopHandling =
                Newtonsoft.Json.ReferenceLoopHandling.Ignore;});



        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/error");
                //app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseStaticFiles(new StaticFileOptions {
                FileProvider = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(), "UsersImage")),
                RequestPath = "/staticFile"
            });
            app.UseAuthentication();
            app.UseCookiePolicy();

           

            app.UseMvc(routes =>
            {
                routes.MapRoute(
             name: "areas",
             template: "{area:exists}/{controller=Dashboard}/{action=Index}/{id?}"
               );
                routes.MapRoute(
                    name: "Default",
                    template: "{Controller=Home}/{action=Index}/{id?}");

            });

          




        }
    }
}
