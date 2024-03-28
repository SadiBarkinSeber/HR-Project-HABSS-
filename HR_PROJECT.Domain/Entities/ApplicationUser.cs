using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public int? EmployeeId { get; set; }
        public Employee? Employee { get; set; }
        public int? ManagerId { get; set; }
        public Manager? Manager { get; set; }
        public int? SiteManagerId { get; set; }
        public SiteManager? SiteManager { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? OneTimePassword { get; set; }
    }
}
