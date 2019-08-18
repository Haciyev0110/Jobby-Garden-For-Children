using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobbyGarden.Models;

namespace JobbyGarden.ViewModel
{
    public class BlogmassonryVM
    {
        public List<Blog> blogs { get; set; }
        public List<Comments> comments { get; set; }
        public List<GaleryBlog>  galery { get; set; }
        public List<User>  users { get; set; }
      
    }
}
