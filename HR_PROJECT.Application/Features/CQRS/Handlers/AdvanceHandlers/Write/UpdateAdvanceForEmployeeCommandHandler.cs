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
    public class UpdateAdvanceForEmployeeCommandHandler
    {
        private readonly IRepository<Advance> _repository;
        public UpdateAdvanceForEmployeeCommandHandler(IRepository<Advance> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAdvanceForEmployeeCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.IsCanceled = command.IsCanceled;
            values.ApprovalStatus = command.ApprovalStatus;

            await _repository.UpdateAsync(values);
        }
    }
}
