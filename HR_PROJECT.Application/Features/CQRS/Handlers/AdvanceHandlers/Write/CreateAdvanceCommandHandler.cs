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
    public class CreateAdvanceCommandHandler
    {
        private readonly IRepository<Advance> _repository;
        

        public CreateAdvanceCommandHandler(IRepository<Advance> repository)
        {
            _repository = repository;
            
        }

        public async Task Handle(CreateAdvanceCommand command)
        {
            await _repository.CreateAsync(new Advance
            {
                AdvanceType = command.AdvanceType,
                Amount = command.Amount,
                Currency = command.Currency,
                EmployeeId = command.EmployeeId,
                Description = command.Description,
                ApprovalStatus = command.ApprovalStatus,
                AmountValue = command.AmountValue
            });
        }
    }
}
