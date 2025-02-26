using Assignment02_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Configuration
{
    class InstructorConfiguration : IEntityTypeConfiguration<Instructor>
    {
        public void Configure(EntityTypeBuilder<Instructor> builder)
        {
            builder.Property(I => I.Salary)
                .HasColumnType("decimal(18,3)");

            builder.Property(I => I.HoursRate)
                .HasColumnType("decimal(18,3)");

            builder.Property(I => I.Address)
                .HasDefaultValue("Giza");

            //One To One
            builder.HasOne(I => I.ManageDepartment)
                .WithOne(I => I.Manager)
                .HasForeignKey<Department>(D => D.ManagerId)
                .IsRequired(false);

            //One To many

            builder.HasOne(I => I.Worker)
                .WithMany(D => D.Instructors)
                .HasForeignKey(I => I.DepartmentId)
                .IsRequired(false);
        }
    }
}
