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
    public class SiteManagerConfiguration : IEntityTypeConfiguration<SiteManager>
    {
        public void Configure(EntityTypeBuilder<SiteManager> builder)
        {
            builder.Property(e => e.Wage)
                .HasColumnType("decimal(18,2)");

            

            #region Seed Data
            builder.HasData(
            new SiteManager
            {
                EmployeeId = 15,
                FirstName = "Elon",
                FirstSurname = "Musk",
                DateOfBirth = new DateTime(1973, 09, 21),
                BirthPlace = "Pretoria/South Africa",
                Tc = "75489612354",
                StartDate = new DateTime(2012, 05, 30),
                IsActive = true,
                Position = "CEO",
                Department = "Board of Directors",
                Company = "Amazon Inc.",
                Email = "elon.musk@bilgeadamboost.com",
                Wage = 256423,
                ImagePath = "file.jpg",
                PhoneNumber = "+905423215678",
                Address = "Atalar Mah. Minibüs Cad. 25/6 Kartal/İstanbul",
                UserId = "ff05bc01-696c-4968-8e4f-cc707cceafad",
                Gender = "Male"
            });

            #endregion
        }
    }
}
