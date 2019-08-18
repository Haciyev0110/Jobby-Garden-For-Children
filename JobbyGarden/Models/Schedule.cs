using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JobbyGarden.Models
{
    public class Schedule
    {
        public int Id { get; set; }

        public Datess Datess { get; set; }
        public int DatesId { get; set; }
        public LessonPrograms LessonPrograms { get; set; }
        public int LessonProgramId { get; set; }
        public Classroomm Classroomm { get; set; }
        public int ClassId { get; set; }

    }
}
