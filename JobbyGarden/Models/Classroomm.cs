using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Classroomm
    {
        public int Id { get; set; }
        [Required]
       
        [StringLength(maximumLength: 255, MinimumLength = 10, ErrorMessage = "Dont Correct")]
        public string Name { get; set; }
       
        public string Iamgename { get; set; }
        public int Price { get; set; }
        [Required]
        [DataType(DataType.Text)]
        [StringLength(maximumLength:6000,MinimumLength =10,ErrorMessage ="Dont correct")]
        public string Description { get; set; }
        public int Size { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime Openhourse { get; set; }
        [Required]
        [DataType(DataType.Time)]
        public DateTime Closehours { get; set; }
        [Required]
        [DataType(DataType.Date)]
        public DateTime Startime { get; set; }



        public Teacherr Teacher { get; set; }
        public int TeacherId { get; set; }
        public Age Agee { get; set; }
        public int AgeeId { get; set; }
        public Categoryy Category { get; set; }
        public int CategoryId { get; set; }
    }
}
