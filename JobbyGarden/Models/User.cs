using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class User:IdentityUser
    {

        [Required]
        [StringLength(maximumLength: 250, MinimumLength = 10, ErrorMessage = "Error Not Found")]
        public string Fullname { get; set; }

       
        public string Image { get; set; }
        public bool Status { get; set; }
    }
}
