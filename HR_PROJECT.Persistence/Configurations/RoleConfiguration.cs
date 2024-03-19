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
    public class RoleConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            #region Seed Data

            const string employeeRoleId = "f6040633-db1b-4a48-be54-9f214e77ac9d";
            const string managerRoleId = "f7deff55-ad53-4946-bce3-1208ff6c52e7";

            builder.HasData(new IdentityRole
            {
                Id = employeeRoleId,
                Name = "employee",
                NormalizedName = "EMPLOYEE"
            },

            new IdentityRole 
            {
                Id = managerRoleId,
                Name = "manager",
                NormalizedName = "MANAGER"
            }
            );

            #endregion
        }
    }
}
