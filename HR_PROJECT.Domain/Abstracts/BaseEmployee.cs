using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Abstracts
{
    public abstract class BaseEmployee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string? SecondName { get; set; }
        public string FirstSurname { get; set; }
        public string? SecondSurname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string BirthPlace { get; set; }
        public string Tc { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public bool IsActive { get; set; }
        public string Position { get; set; }
        public string Department { get; set; }
        public string Company { get; set; }
        public string Email { get; set; }
        public decimal Wage { get; set; }
        public string ImagePath { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        public ICollection<Expense> Expenses { get; set; }

        public ICollection<Permission> Permissions { get; set; }

        public ICollection<Advance> Advances { get; set; }
    }
}
