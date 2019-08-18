using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Teacherr
    {
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Fullname { get; set; }
        public string Images { get; set; }
        [Required]
        [StringLength(maximumLength:4000,MinimumLength =10,ErrorMessage ="Dont correct is Description")]
        public string Minidescription { get; set; }
        [Required]
        [StringLength(maximumLength: 1000, MinimumLength = 10, ErrorMessage = "Dont correct is Description")]
        public string TitleDesc { get; set; }
        [Required]
        [StringLength(maximumLength:100,MinimumLength =5,ErrorMessage ="Dont correct")]
        public string Special { get; set; }
        [Required]
        public int Experience { get; set; }
        [Required]
        [Phone]
        [DataType(DataType.PhoneNumber)]
        public string Phone { get; set; }
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.MultilineText)]
        public string Sliderdesc { get; set; }

    }
}
