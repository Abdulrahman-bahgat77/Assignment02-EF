using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Principal;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Entities
{
    class StudentCourse
    {
        public int StudentId { get; set; }
        public int CourseId { get; set; }

        public int grade { get; set; }
    }
}
