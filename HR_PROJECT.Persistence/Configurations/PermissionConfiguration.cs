using HR_PROJECT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Configurations
{
    public class PermissionConfiguration : IEntityTypeConfiguration<Permission>
    {
        public void Configure(EntityTypeBuilder<Permission> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.PermissionType)
                .IsRequired();

            builder.Property(p => p.RequestDate)
                .IsRequired();

            builder.Property(p => p.StartDate)
                .IsRequired();

            builder.Property(p => p.EndDate)
                .IsRequired();

            builder.Property(p => p.ApprovalStatus)
                .IsRequired();

            builder.HasOne(p => p.Employee)
                .WithMany(e => e.Permissions)
                .HasForeignKey(p => p.EmployeeId)
                .IsRequired();


            #region Seed Data

            builder.HasData(
                
            new Permission
            {
                Id = 1,
                PermissionType = "Baba izni",
                StartDate = new DateTime(2024, 3, 14),
                EndDate = new DateTime(2024, 3, 24),
                NumberOfDays = 10,
                EmployeeId = 1
            },
            new Permission
            {
                   Id = 2,
                   PermissionType = "Annelik izni",
                   StartDate = new DateTime(2024, 3, 15),
                   EndDate = new DateTime(2024, 4, 15),
                   NumberOfDays = 30,
                   EmployeeId = 1
            }
            );

            #endregion
        }
    }
}
