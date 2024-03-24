using HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Write
{
    public class UpdateExpenseForManagerCommandHandler
    {
        private readonly IRepository<Expense> _repository;

        public UpdateExpenseForManagerCommandHandler(IRepository<Expense> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateExpenseForManagerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);
            values.Permission = command.Permission;
            values.ApprovalStatus = command.ApprovalStatus;

            await _repository.UpdateAsync(values);
            
        }
    }
}
