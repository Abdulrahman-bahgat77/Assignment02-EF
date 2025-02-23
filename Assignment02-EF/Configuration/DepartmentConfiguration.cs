using Assignment02_EF.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment02_EF.Configuration
{
    class DepartmentConfiguration : IEntityTypeConfiguration<Department>
    {
        public void Configure(EntityTypeBuilder<Department> builder)
        {
            builder.Property(D => D.Id)
                .UseIdentityColumn(10, 10);

            builder.Property(D => D.HiringDate)
                .HasComputedColumnSql("GETDATE()");

            //One T one

            builder.HasOne(D => D.Manager)
                .WithOne(I => I.ManageDepartment)
                .HasForeignKey<Department>(D => D.ManagerId)
                .IsRequired(false);

            //MAny To Many

            builder.HasMany(D=>D.Instructors)
                .WithOne(I=>I.Worker)
                .IsRequired(false)
                .HasForeignKey(I=>I.DepartmentId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
