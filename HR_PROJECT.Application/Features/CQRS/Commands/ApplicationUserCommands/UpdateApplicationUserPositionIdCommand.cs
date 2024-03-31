using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.ApplicationUserCommands
{
    public class UpdateApplicationUserPositionIdCommand
    {
        public string Id { get; set; }
        public int PositionId { get; set; }
        public string RoleName { get; set; }
    }
}
