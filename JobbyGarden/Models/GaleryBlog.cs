using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class GaleryBlog
    {
        public int Id { get; set; }
      
        public string ImageBlog { get; set; }

        public Blog Blog { get; set; }
        public int BlogId { get; set; }
    }
}
