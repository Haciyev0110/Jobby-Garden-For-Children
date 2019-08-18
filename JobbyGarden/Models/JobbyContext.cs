using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace JobbyGarden.Models
{
    public class JobbyContext:IdentityDbContext<User,IdentityRole,string>
    {
        public JobbyContext(DbContextOptions<JobbyContext> options) : base(options)
        {
        }
        public DbSet<Categoryy> Categoryies { get; set; }
        public DbSet<Age> Ages { get; set; }
        public DbSet<Teacherr> Teacherrs { get; set; }
        public DbSet<Classroomm> Classroomms { get; set; }
        public DbSet<BlogCategory> BlogCategories { get; set; }
        public DbSet<GaleryBlog> GaleryBlogs { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Comments> Comments { get; set; }
        public DbSet<Datess> Datesses { get; set; }
        public DbSet<Days> Days { get; set; }
        public DbSet<LessonPrograms> LessonPrograms { get; set; }
        public DbSet<Months> Months { get; set; }
        public DbSet<Schedule> Schedules { get; set; }
        public DbSet<Entroll> Entrolls { get; set; }



    }
}
