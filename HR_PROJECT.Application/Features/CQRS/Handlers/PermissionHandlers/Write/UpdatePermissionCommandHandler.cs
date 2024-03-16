using HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands;
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
    public class UpdatePermissionCommandHandler
    {
        private readonly IRepository<Permission> _repository;
        public UpdatePermissionCommandHandler(IRepository<Permission> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePermissionCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.PermissionType = command.PermissionType;
            values.StartDate = command.StartDate;
            values.EndDate = command.EndDate;
            values.NumberOfDays = command.NumberOfDays;
            values.ApprovalStatus = command.ApprovalStatus;
            values.FileName = command.FileName;

            await _repository.UpdateAsync(values);
        }

    }
}
