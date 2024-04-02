using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands
{
    public class CreateExpenseCommand
    {
        public CreateExpenseCommand()
        {
            RequestDate = DateTime.Now;
            
        }
        public string ExpenseType { get; set; }
        public decimal Amount { get; set; }
        public string ApprovalStatus { get; } = "Talep Edildi";
        public DateTime RequestDate { get; }
        
        public string Currency { get; set; }
        
        public int EmployeeId { get; set; }
        public string? FileName { get; set; }

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
    }
}
