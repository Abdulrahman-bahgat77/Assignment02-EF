using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Entities
{
    class Student
    {
        public int Id { get; set; }
        public string FName { get; set; }

        public string LName { get; set; }

        public string Address { get; set; }
        public int Age { get; set; }

        [ForeignKey("Department")]
        public int DepartmentId { get; set; }
        [InverseProperty("Students")]
        public Department Department { get; set; }

        public ICollection<StudentCourse> StudentCourses { get; set; }= new HashSet<StudentCourse>();
        
    }
}
