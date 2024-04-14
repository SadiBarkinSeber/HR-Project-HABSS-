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
    public class GetPermissionQueryHandler
    {
        private readonly IPermissionRepository _permissionRepository;

        public GetPermissionQueryHandler(IPermissionRepository repository)
        {
            _permissionRepository = repository;
        }

        public async Task<List<GetPermissionQueryResult>> Handle()
        {
            var values = await _permissionRepository.GetPermissionsWithEmployees();
            return values.Select(p => new GetPermissionQueryResult
            {
                Id = p.Id,
                PermissionType = p.PermissionType,
                StartDate = p.StartDate,
                EndDate = p.EndDate,
                NumberOfDays = p.NumberOfDays,
                FileName = p.FileName,
                ApprovalStatus = p.ApprovalStatus,
                EmployeeId = p.EmployeeId,
                IsApproved = p.IsApproved,
                EmployeeFirstName = p.Employee.FirstName,
                EmployeeSecondName = p.Employee.SecondName,
                EmployeeLastName = p.Employee.FirstSurname,
                EmployeeSecondLastName = p.Employee.SecondSurname,
                RequestDate = p.RequestDate
            }).ToList();
        }
    }
}
