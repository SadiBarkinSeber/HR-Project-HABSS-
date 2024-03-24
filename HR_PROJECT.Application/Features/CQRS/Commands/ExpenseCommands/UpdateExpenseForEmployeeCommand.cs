using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands
{
    public class UpdateExpenseForEmployeeCommand
    {
        public int Id { get; set; }
        public bool IsCancelled { get; set; }
        public string ApprovalStatus { get; } = "Cancelled";
    }
}
