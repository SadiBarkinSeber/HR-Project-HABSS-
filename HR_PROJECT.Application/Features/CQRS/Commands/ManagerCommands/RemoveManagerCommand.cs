using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.ManagerCommands
{
    public class RemoveManagerCommand
    {
        public int Id { get; set; }

        public RemoveManagerCommand(int id)
        {
            Id = id;
        }
    }
}
