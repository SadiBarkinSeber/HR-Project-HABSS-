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
    public class ManagerConfiguration : IEntityTypeConfiguration<Manager>
    {
        public void Configure(EntityTypeBuilder<Manager> builder)
        {
            builder.Property(e => e.Wage)
                .HasColumnType("decimal(18,2)");

            #region Seed Data

            builder.HasData(

                new Manager
                {
                    EmployeeId = 3,
                    FirstName = "Leonardo",
                    FirstSurname = "Da Vinci",
                    DateOfBirth = new DateTime(1990, 08, 15),
                    BirthPlace = "Florence/Italy",
                    Tc = "54696378921",
                    StartDate = new DateTime(2015, 12, 26),
                    IsActive = true,
                    Position = "IT Manager",
                    Department = "Technology and Strategy",
                    Company = "Amazon Inc.",
                    Email = "leonardo.davinci@bilgeadam.com",
                    Wage = 156245,
                    ImagePath = "file.jpg",
                    PhoneNumber = "+905075217896",
                    Address = "Yıldız Mah. Barbaros Bulvarı Beşiktaş/İstanbul",
                    UserId = "29eee336-e6a2-40f2-9305-159eed59ed75",
                    Gender = "Male"
                }

                ); 

            #endregion

        }


    }
}
