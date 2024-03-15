using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.PermissionQueries;
using HR_PROJECT.Application.Features.CQRS.Results.EmployeeResults;
using HR_PROJECT.Application.Features.CQRS.Results.PermissionResults;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Read
{
    public class GetPermissionsByEmployeeIDHandler
    {
        private readonly IPermissionRepository _repository;

        public GetPermissionsByEmployeeIDHandler(IPermissionRepository repository)
        {
            _repository = repository;
        }

        public async Task<GetPermissionsByEmployeeIDQueryResult> Handle(GetPermissionsByEmployeeIDQuery query)
        {
            var permissions = await _repository.GetAllPermissionsByEmployeeID(query.Id);

            if (permissions == null)
                return new GetPermissionsByEmployeeIDQueryResult { Permissions = new List<Permission>() };

            var result = new GetPermissionsByEmployeeIDQueryResult
            {
                Permissions = permissions
            };

            return result;
        }
    }


}
