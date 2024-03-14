using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class Expense
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public decimal Amount { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime RequestDate { get; set; }
        public string Response { get; set; }
        public string Currency { get; set; }
        public bool Permission { get; set; }
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }
        public string? FileName { get; set; }
    }
}
