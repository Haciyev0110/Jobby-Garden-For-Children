using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobbyGarden.Models;
using Microsoft.AspNetCore.Identity;

namespace JobbyGarden
{
    public class Sample
    {

        public static void Initialize(JobbyContext context,UserManager<User> userManager,RoleManager<IdentityRole> roleManager)
        {
            if (!context.Roles.Any())
            {
                IdentityRole identityRole = new IdentityRole("Admin");
                IdentityRole identityRole2 = new IdentityRole("User");
                roleManager.CreateAsync(identityRole).GetAwaiter().GetResult();
                roleManager.CreateAsync(identityRole2).GetAwaiter().GetResult();
            }
            if (!context.Users.Any())
            {


                User user = new User
                {
                    UserName = "Penah0110",
                    Fullname = "Panah Haciyev",
                    Image = "user1.img",
                    Email = "penah@gmail.com"

                };
                IdentityResult identityResult = userManager.CreateAsync(user, "panah123").GetAwaiter().GetResult();

                if (identityResult.Succeeded)
                {
                     userManager.AddToRoleAsync(user, "Admin").GetAwaiter().GetResult();
                }
            }
            if (!context.Categoryies.Any())
            {

                context.Categoryies.AddRange(
                    new Categoryy
                    {
                        Name = "Play Group"


                    },
                    new Categoryy
                    {
                        Name = "Primary"
                    },
                    new Categoryy {
                        Name = "Story"
                    }
                        
                    );
                context.SaveChanges();
            }


        }
    }
}
