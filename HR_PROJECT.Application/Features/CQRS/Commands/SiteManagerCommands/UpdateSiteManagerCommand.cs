using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Commands.SiteManagerCommands
{
    public class UpdateSiteManagerCommand
    {
        public int Id { get; set; }
        public string Phonenumber { get; set; }
        public string Address { get; set; }
        public string ImagePath { get; set; }
    }
}
