using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Entities
{
    class Course
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Discripition { get; set; }
        public int Duration { get; set; }

        [ForeignKey("Topics")]
        public int? TopicId { get; set; }
        public Topic Topics  { get; set; }

        public ICollection<StudentCourse> CourseStudents { get; set; } = new HashSet<StudentCourse>();

        public ICollection<CourseInstructor> CourseInstructor { get; set; } = new HashSet<CourseInstructor>();
    }
}
