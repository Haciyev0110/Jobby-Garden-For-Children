using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Datess
    {
        public int Id { get; set; }
        [Required]
        [StringLength(maximumLength:100,MinimumLength =5)]
        public string Startime { get; set; }
        [Required]
        [StringLength(maximumLength: 100, MinimumLength = 5)]
        public string Endtime { get; set; }

        public Days Days { get; set; }
        public int DaysId { get; set; }
    }
}
