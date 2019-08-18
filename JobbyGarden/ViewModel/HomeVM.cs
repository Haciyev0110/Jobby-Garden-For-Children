using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobbyGarden.Models;

namespace JobbyGarden.ViewModel
{
    public class HomeVM
    {
        public List<Classroomm> classroms { get; set; }
        public List<Teacherr> teacherrs { get; set; }
        public Teacherr TeacherFirst { get; set; }
        public List<Age> ages { get; set; }
        public List<Categoryy> categ { get; set; }
        public List<Blog> blogs { get; set; }
        public List<User> users { get; set; }
        public List<Comments> comments { get; set; }
        public List<GaleryBlog> galeryBlogs { get; set; }
        public Entroll entroll { get; set; }
    }
}
