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
    public class IdentityuserRoleConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            #region Seed Data

            const string employeeRoleId = "f6040633-db1b-4a48-be54-9f214e77ac9d";
            const string managerRoleId = "f7deff55-ad53-4946-bce3-1208ff6c52e7";
            const string siteManagerRoleId = "376a70f6-531c-40c5-ace7-ecf8964de6a4";

            const string userId = "df5a9b38-18e8-48b7-97bf-ad4a9b4afe0e";
            const string appManagerId = "29eee336-e6a2-40f2-9305-159eed59ed75";
            const string siteManagerId = "ff05bc01-696c-4968-8e4f-cc707cceafad";

            builder.HasData(

                new IdentityUserRole<string>
                {
                    UserId = appManagerId,
                    RoleId = managerRoleId,
                },

                new IdentityUserRole<string>
                {
                    UserId = userId,
                    RoleId = employeeRoleId
                },

                new IdentityUserRole<string>
                {
                    UserId = appManagerId,
                    RoleId = employeeRoleId
                },

                new IdentityUserRole<string>
                {
                    UserId = siteManagerId,
                    RoleId = siteManagerRoleId
                }

                );

            #endregion
        }
    }
}
