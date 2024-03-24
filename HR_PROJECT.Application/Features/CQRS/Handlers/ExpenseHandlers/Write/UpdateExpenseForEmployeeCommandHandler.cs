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
    public class UpdateExpenseForEmployeeCommandHandler
    {
        private readonly IRepository<Expense> _repository;

        public UpdateExpenseForEmployeeCommandHandler(IRepository<Expense> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateExpenseForEmployeeCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.IsCancelled = command.IsCancelled;
            values.ApprovalStatus = command.ApprovalStatus;

            await _repository.UpdateAsync(values);
        }
    }
}
