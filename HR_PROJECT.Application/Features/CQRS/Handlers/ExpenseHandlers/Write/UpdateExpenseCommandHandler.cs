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
    public class UpdateExpenseCommandHandler
    {
        private readonly IRepository<Expense> _repository;
        public UpdateExpenseCommandHandler(IRepository<Expense> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateExpenseCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.Type = command.Type;
            values.Amount = command.Amount;
            values.ApprovalStatus = command.ApprovalStatus;
            values.RequestDate = command.RequestDate;
            values.Response = command.Response;
            values.Currency = command.Currency;
            values.Permission = command.Permission;
            values.EmployeeId = command.EmployeeId;
            values.FileName = command.FileName;
        }
    }
}
