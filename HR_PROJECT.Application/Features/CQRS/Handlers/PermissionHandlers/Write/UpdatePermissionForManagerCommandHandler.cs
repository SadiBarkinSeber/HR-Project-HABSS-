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
    public class UpdatePermissionForManagerCommandHandler
    {
        private readonly IRepository<Permission> _repository;

        public UpdatePermissionForManagerCommandHandler(IRepository<Permission> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdatePermissionForManagerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.IsApproved = command.IsApproved;
            values.ApprovalStatus = command.ApprovalStatus;

            await _repository.UpdateAsync(values);
        }
    }
}
