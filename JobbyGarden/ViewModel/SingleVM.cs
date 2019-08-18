using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using JobbyGarden.Models;

namespace JobbyGarden.ViewModel
{
    public class SingleVM
    {
        public Classroomm clasrom { get; set; }
        public List<Teacherr>  teacherr { get; set; }
        public Teacherr teacearSingle { get; set; }
        public Age age { get; set; }
        public List<Age> agess { get; set; }
        public List<Classroomm> clasr { get; set; }
    }
}
