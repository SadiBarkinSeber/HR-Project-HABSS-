using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands
{
    public class UpdateExpenseForManagerCommand
    {
        public int Id { get; set; }
        public bool? IsApproved {  get; set; }
        private string approvalStatus;

        public string ApprovalStatus
        {
            get 
            {
                if (IsApproved == true)
                {
                    approvalStatus = "Onaylandı";
                }
                else
                {
                    approvalStatus = "Reddedildi";
                }
                return approvalStatus; 
            }
            
        }

    }
}
