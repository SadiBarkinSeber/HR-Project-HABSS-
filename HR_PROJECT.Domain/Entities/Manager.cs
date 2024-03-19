using HR_PROJECT.Domain.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Domain.Entities
{
    public class Manager : BaseEmployee
    {
        public string UserId { get; set; }
        public ApplicationUser User { get; set; }
    }
}
