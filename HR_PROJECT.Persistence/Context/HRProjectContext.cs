﻿using HR_PROJECT.Domain.Entities;
using HR_PROJECT.Persistence.Configurations;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Context
{
    public class HRProjectContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Expense> Expenses { get; set; }
        public DbSet<Permission> Permissions { get; set; }
        public DbSet<Advance> Advances { get; set; }
        public DbSet<Manager> Managers { get; set; }
        public DbSet<SiteManager> SiteManagers { get; set; }
        public DbSet<Company> Companies { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("SQL Connection String", builder =>
            {
                builder.EnableRetryOnFailure(5, TimeSpan.FromSeconds(10), null);
            });

            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EmployeeConfiguration());
            modelBuilder.ApplyConfiguration(new ManagerConfiguration());
            modelBuilder.ApplyConfiguration(new SiteManagerConfiguration());
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            modelBuilder.ApplyConfiguration(new ApplicationUserConfiguration());
            modelBuilder.ApplyConfiguration(new IdentityuserRoleConfiguration());
            modelBuilder.ApplyConfiguration(new ExpenseConfiguration());
            modelBuilder.ApplyConfiguration(new PermissionConfiguration());
            modelBuilder.ApplyConfiguration(new AdvanceConfiguration());

            base.OnModelCreating(modelBuilder);
        }
 
    }
}
