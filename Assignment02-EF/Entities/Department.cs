using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Entities
{
    class Department
    {
        public int Id { get; set; }
        public string ? Name { get; set; }
        public DateTime HiringDate { get; set; }

        [ForeignKey("Manager")]
        public int ManagerId { get; set; }

        [InverseProperty("ManageDepartment")] //Note
        public   Instructor Manager { get; set; }

        [InverseProperty("Worker")]
        public ICollection<Instructor> Instructors { get; set; } = new HashSet<Instructor>();

        [InverseProperty("Department")]
        public ICollection<Student> Students { get; set; }=new HashSet<Student>();
    }
}
