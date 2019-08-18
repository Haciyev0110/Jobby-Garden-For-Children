using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Days
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string Name { get; set; }


        public Months Months { get; set; }
        public int MonthId { get; set; }
    }
}
