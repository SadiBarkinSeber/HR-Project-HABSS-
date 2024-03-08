using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands
{
    public class UpdateEmployeeCommand
    {
        public int Id { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
    }
}
