using HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Write
{
    public class RemoveAdvanceCommandHandler
    {
        private readonly IRepository<Advance> _repository;

        public RemoveAdvanceCommandHandler(IRepository<Advance> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveAdvanceCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
