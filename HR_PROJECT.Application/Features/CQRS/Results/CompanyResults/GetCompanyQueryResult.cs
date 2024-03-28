using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Results.CompanyResults
{
    public class GetCompanyQueryResult
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string MersisNo { get; set; }
        public string TaxNumber { get; set; }
        public string TaxDepartment { get; set; }
        public string PhoneNumber { get; set; }
        public string LogoImagePath { get; set; }
        public string Address { get; set; }
        public string Email { get; set; }
        public int EmployeeCount { get; set; }
        public DateTime FoundingDate { get; set; }
        public DateTime DealStartDate { get; set; }
        public DateTime? DealEndDate { get; set; }
        public bool IsActive { get; set; }
    }
}
