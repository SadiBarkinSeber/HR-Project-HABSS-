using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands
{
    public class UpdateAdvanceForEmployeeCommand
    {
        public int Id { get; set; }
        public bool? IsCanceled { get; set; }
        public string ApprovalStatus { get; } = "İptal Edildi";
    }
}
