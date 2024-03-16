using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands
{
    public class RemovePermissionCommand
    {
        public int Id { get; set; }

        public RemovePermissionCommand(int id)
        {
            Id = id;
        }
    }
}
