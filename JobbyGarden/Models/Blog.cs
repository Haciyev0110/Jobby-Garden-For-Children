using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Blog
    {
        public Blog()
        {
            GaleryBlogs = new List<GaleryBlog>();
            Comments = new List<Comments>();
        }
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:150,MinimumLength =5,ErrorMessage ="Dont Correct")]
        public string Name { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:4000,MinimumLength =10,ErrorMessage ="Error Not Found")]
        public string Blogdesc1 { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength: 4000, MinimumLength = 10, ErrorMessage = "Error Not Found")]
        public string Blogdesc2 { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:800, MinimumLength = 10, ErrorMessage = "Error Not Found")]
        public string Title { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }
        public bool Status { get; set; }


        public BlogCategory blogCategory { get; set; }
        public int BlogcategoryId { get; set; }
        public List<GaleryBlog>  GaleryBlogs { get; set; }
        public List<Comments> Comments { get; set; }
        public User User { get; set; }
        public string UserId { get; set; }

    }
}
