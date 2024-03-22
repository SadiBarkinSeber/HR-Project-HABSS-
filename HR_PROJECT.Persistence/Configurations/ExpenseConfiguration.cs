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
    public class ExpenseConfiguration : IEntityTypeConfiguration<Expense>
    {
        public void Configure(EntityTypeBuilder<Expense> builder)
        {
            builder.Property(e => e.Amount)
                .HasColumnType("decimal(18,2)");
            builder.Property(e => e.AmountValue)
                .HasColumnType("decimal(18,2)");

            #region Seed Data

            builder.HasData(

                new Expense
                {
                    Id = 1,
                    ExpenseType = "İş Seyahatleri",
                    Amount = 5631.45m,
                    ApprovalStatus = "Pending",
                    RequestDate = new DateTime(2024, 3, 14),
                    Response = "Please provide necessary documents.",
                    Currency = "TL",
                    Permission = false,
                    EmployeeId = 1
                },

                new Expense
                {
                    Id = 2,
                    ExpenseType = "Personel Harcamaları",
                    Amount = 6592.45m,
                    ApprovalStatus = "Approved",
                    RequestDate = new DateTime(2024, 3, 10),
                    Response = "Request have been approved.",
                    Currency = "TL",
                    Permission = true,
                    EmployeeId = 1
                }

                );

            #endregion
        }
    }
}
