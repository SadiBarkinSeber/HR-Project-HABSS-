using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Results.AdvanceResults
{
    public class GetAdvanceQueryResult
    {
        public int Id { get; set; }
        public string AdvanceType { get; set; }
        public decimal Amount { get; set; }
        public string ApprovalStatus { get; set; }
        public DateTime RequestDate { get; set; } = DateTime.Now;
        public string Response { get; set; }
        public string Currency { get; set; }
        public bool Permission { get; set; }
        public int EmployeeId { get; set; }
        public string Description { get; set; }
        public decimal? AmountValue { get; set; }
    }
}
