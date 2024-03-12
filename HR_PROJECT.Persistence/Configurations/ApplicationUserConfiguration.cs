using HR_PROJECT.Domain.Entities;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Configurations
{
    public class ApplicationUserConfiguration : IEntityTypeConfiguration<ApplicationUser>
    {
        public void Configure(EntityTypeBuilder<ApplicationUser> builder)
        {

            builder.HasOne(e => e.Employee)
            .WithOne(e => e.User)
            .HasForeignKey<Employee>(e => e.UserId)
            .IsRequired(false);


            #region Seed Data
            const string userId = "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e";
            var hasher = new PasswordHasher<ApplicationUser>();

            builder.HasData(new ApplicationUser
            {
                Id = userId,
                UserName = "sahzod",
                NormalizedUserName = "SAHZOD",
                Email = "sahzod.irgas@bilgeadam.com",
                NormalizedEmail = "SAHZOD.IRGAS@BILGEADAM.COM",
                PasswordHash = hasher.HashPassword(null, "Anyela123+"),
                SecurityStamp = string.Empty,   
                EmployeeId = 1
            });
            #endregion

        }
    }
}
