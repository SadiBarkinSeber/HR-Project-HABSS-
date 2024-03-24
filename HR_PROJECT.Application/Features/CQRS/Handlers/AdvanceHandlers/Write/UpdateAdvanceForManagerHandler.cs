using HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Write
{
    public class UpdateAdvanceForManagerHandler
    {
        private readonly IRepository<Advance> _repository;
        public UpdateAdvanceForManagerHandler(IRepository<Advance> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAdvanceForManagerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.Permission = command.Permission;
            values.ApprovalStatus = command.ApprovalStatus;

            await _repository.UpdateAsync(values);
        }
    }
}
