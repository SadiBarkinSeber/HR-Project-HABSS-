using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Results.PermissionResults
{
    public class GetPermissionsByEmployeeIDQueryResult
    {
        public List<Permission> Permissions { get; set; }
    }

}
