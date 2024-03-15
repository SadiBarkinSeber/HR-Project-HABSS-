using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Write
{
    public class CreatePermissionCommandHandler
    {
        private readonly IRepository<Permission> _repository;

        public CreatePermissionCommandHandler(IRepository<Permission> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreatePermissionCommand command)
        {
            await _repository.CreateAsync(new Permission
            {
                PermissionType = command.PermissionType,
                StartDate = command.StartDate,
                EndDate = command.EndDate,
                NumberOfDays = command.NumberOfDays,
                FileName = command.FileName,
                ApprovalStatus = command.ApprovalStatus,
                EmployeeId = command.EmployeeId,
            });
        }
    }
}
