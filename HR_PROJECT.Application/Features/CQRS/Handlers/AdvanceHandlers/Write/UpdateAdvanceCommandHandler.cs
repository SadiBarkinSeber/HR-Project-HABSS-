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
    public class UpdateAdvanceCommandHandler
    {
        private readonly IRepository<Advance> _repository;
        public UpdateAdvanceCommandHandler(IRepository<Advance> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateAdvanceCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.AdvanceType = command.AdvanceType;
            values.Amount = command.Amount;
            values.ApprovalStatus = command.ApprovalStatus;
            values.Currency = command.Currency;
            values.IsApproved = command.Permission;
            values.EmployeeId = command.EmployeeId;
            values.Description = command.Description;

            await _repository.UpdateAsync(values);
        }
    }
}
