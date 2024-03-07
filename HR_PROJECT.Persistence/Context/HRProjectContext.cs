using HR_PROJECT.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Context
{
    public class HRProjectContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=tcp:sahzodsserver.database.windows.net,1433;Initial Catalog=HR_DB;Persist Security Info=False;User ID=sahzod;Password=Anyela123;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });

            base.OnConfiguring(optionsBuilder);
        }

        public DbSet<Employee> Employees { get; set; }
    }
}
