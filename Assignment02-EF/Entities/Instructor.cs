using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Entities
{
    class Instructor
    {
        public int Id { get; set; }
        public string  Name { get; set; }
        public decimal Salary { get; set; }
        public string Address { get; set; }
        public double Bouns { get; set; }
        public decimal HoursRate { get; set; }
        [InverseProperty(nameof(Department.Manager))] //Note
        public Department ManageDepartment { get; set; } //Navigation Property One

        [ForeignKey(nameof(Worker))]
        public int ?DepartmentId { get; set; }

        [InverseProperty(nameof(Department.Instructors))]
        public Department Worker { get; set; }

        public ICollection<CourseInstructor> InstructorCourse { get; set; } = new HashSet<CourseInstructor>();
    }
}
