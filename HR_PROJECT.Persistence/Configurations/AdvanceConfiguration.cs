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
    public class AdvanceConfiguration : IEntityTypeConfiguration<Advance>
    {
        
        public void Configure(EntityTypeBuilder<Advance> builder)
        {
            builder.Property(e => e.Amount)
                .HasColumnType("decimal(18,2)");
            builder.Property(e => e.AmountValue)
                .HasColumnType("decimal(18,2)");
            builder.HasKey(p => p.Id);

            builder.Property(p => p.AdvanceType)
                .IsRequired();

            builder.Property(p => p.RequestDate)
                .IsRequired();

            builder.Property(p => p.ApprovalStatus)
                .IsRequired();

            builder.HasOne(p => p.Employee)
                .WithMany(e => e.Advances)
                .HasForeignKey(p => p.EmployeeId)
                .IsRequired();

            builder.Property(p => p.Description) 
                .IsRequired()
                .HasMaxLength(500);

            #region Seed Data

            builder.HasData(

                new Advance
                {
                    Id = 1,
                    AdvanceType = "Bireysel",
                    Amount = 5631.45m,
                    ApprovalStatus = "Pending",
                    Response = "Please provide necessary documents.",
                    Currency = "TL",
                    IsApproved = false,
                    EmployeeId = 1,
                    Description = "Araba alıcam"
                },

                new Advance
                {
                    Id = 2,
                    AdvanceType = "Kurumsal",
                    Amount = 6592.45m,
                    ApprovalStatus = "Approved",
                    Response = "Request have been approved.",
                    Currency = "TL",
                    IsApproved = true,
                    EmployeeId = 1,
                    Description = "Motor alıcam"
                }

                );

            #endregion
        }
    }
}
