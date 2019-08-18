using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Entroll
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:250,MinimumLength =5)]
        public string Parentname { get; set; }
        [Required]
        [StringLength(maximumLength:250,MinimumLength =5)]
        public string Waitinglist { get; set; }
        [Required]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string  Phone { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:6000,MinimumLength =10)]
        public string MessageTex { get; set; }
    }
}
