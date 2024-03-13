using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.ApplicationUserCommands
{
    public class LoginApplicationUserDTO
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
