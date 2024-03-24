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
    public class UpdatepermissionForEmployeeCommandHandler
    {
        private readonly IRepository<Permission> _repository;
        public UpdatepermissionForEmployeeCommandHandler(IRepository<Permission> repository)
        {
            _repository = repository;
        }


        public async Task Handle(UpdatePermissionForEmployeeCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.IsCancelled = command.IsCancelled;
            values.ApprovalStatus = command.ApprovalStatus;

            await _repository.UpdateAsync(values);
        }
    }
}
