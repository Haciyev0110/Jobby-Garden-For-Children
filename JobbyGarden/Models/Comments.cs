using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Comments
    {
        public int Id { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:4000,MinimumLength =10,ErrorMessage ="Error Not Found")]
        public string Descripton { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Date { get; set; }


        public User User { get; set; }
        public string UserId { get; set; }
        public Blog Blog { get; set; }
        public int BlogId { get; set; }

    }
}
