using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobbyGarden.Models;

namespace JobbyGarden.ViewModel
{
    public class BlogSingleVM
    {
        public Blog blog { get; set; }
        public List<Blog> bloglist { get; set; }
        public List<User> users { get; set; }
        public Comments comments { get; set; }
        public List<BlogCategory> blogCategories { get; set; }
        public List<GaleryBlog> galeryBlogs { get; set; }
        public List<GaleryBlog> galery2Image { get; set; }
        public List<GaleryBlog> galery3Image { get; set; }
        public List<GaleryBlog> galery4Image { get; set; }
        public List<Comments> comajx { get; set; }



    }
}
