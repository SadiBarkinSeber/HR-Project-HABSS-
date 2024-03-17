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
        private readonly IRepository<Permission> _repository;

        public GetPermissionQueryHandler(IRepository<Permission> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetPermissionQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(p => new GetPermissionQueryResult
            {
                Id = p.Id,
                PermissionType = p.PermissionType,
                StartDate = DateTime.Now,
                EndDate = DateTime.Now,
                NumberOfDays = p.NumberOfDays,
                FileName = p.FileName,
                ApprovalStatus = p.ApprovalStatus,
                EmployeeId = p.EmployeeId,
                IsApproved = p.IsApproved
            }).ToList();
        }
    }
}
