
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands
{
    public class CreateAdvanceCommand
    {
        
        public CreateAdvanceCommand()
        {
            RequestDate = DateTime.Now;
            
        }


        public string AdvanceType { get; set; }
        public string ApprovalStatus { get; } = "Requested";
        public decimal Amount { get; set; }

        private static readonly Dictionary<string, decimal> ExchangeRates = new Dictionary<string, decimal>
        {
            { "USD", 32 },
            { "EUR", 34 },
            { "TL", 1 }
        };
        public decimal? AmountValue
        {
            get
            {  
                return Amount * ExchangeRates[Currency];
            }
        }
        public DateTime RequestDate { get; set; }
        public int EmployeeId { get; set; }
        public string Currency { get; set; }
        public string Description { get; set; }

    }
}
