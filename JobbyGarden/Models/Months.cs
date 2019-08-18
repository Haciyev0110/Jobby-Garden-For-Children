﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Months
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 250, MinimumLength = 10, ErrorMessage = "Error Not Found")]
        public string Name { get; set; }
    }
}
