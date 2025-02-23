using Assignment02_EF.Configuration;
using Assignment02_EF.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Context
{
    class ITIDbContext:DbContext
    {
        public DbSet<Course> Courses { get; set; }
        public DbSet<Department> Departmentes { get; set; }
        public DbSet<Instructor> Instructores { get; set; }

        public DbSet<Student> Studentes { get; set; }
        public DbSet<Topic> Topices { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=. ; Database=ITIAs ; Trusted_Connection=True");
             
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new CourseInstructorConfig());
            modelBuilder.ApplyConfiguration(new DepartmentConfiguration());
            modelBuilder.ApplyConfiguration(new InstructorConfiguration());
            modelBuilder.ApplyConfiguration(new StudentConfiguration());
            modelBuilder.ApplyConfiguration(new StudentCourseCongif());

            base.OnModelCreating(modelBuilder);
        }
    }
}
