using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

using JobbyGarden.Models;
using Microsoft.AspNetCore.Identity;

namespace JobbyGarden
{
    public class Program
    {
        public static void Main(string[] args)
        {

            var host = CreateWebHostBuilder(args).Build();

            using (var scop = host.Services.CreateScope())
            {

                using(JobbyContext dbContext = scop.ServiceProvider.GetRequiredService<JobbyContext>())
                {
                    using(var userManager = scop.ServiceProvider.GetRequiredService<UserManager<User>>())
                    {
                        using(var roleManager = scop.ServiceProvider.GetRequiredService<RoleManager<IdentityRole>>())
                        {
                            try
                            {
                                Sample.Initialize(dbContext,userManager,roleManager);
                            }
                            catch (Exception ex)
                            {
                                var logger = scop.ServiceProvider.GetRequiredService<ILogger<Program>>();
                                logger.LogError(ex, "dont correct add method");
                            }
                        }
                    }
                }
            }

                host.Run();

        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseStartup<Startup>();
    }
}
