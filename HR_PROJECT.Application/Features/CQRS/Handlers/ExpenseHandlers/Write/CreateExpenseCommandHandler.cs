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
    public class CreateExpenseCommandHandler
    {
        private readonly IRepository<Expense> _repository;

        public CreateExpenseCommandHandler(IRepository<Expense> repository)
        {
            _repository = repository;
        }

        public async Task Handle(CreateExpenseCommand command)
        {
            await _repository.CreateAsync(new Expense
            {
                ExpenseType = command.ExpenseType,
                Amount = command.Amount,
                ApprovalStatus = command.ApprovalStatus,
                RequestDate = command.RequestDate,
                Response = command.Response,
                Currency = command.Currency,
                AmountValue = command.AmountValue,
                EmployeeId = command.EmployeeId,
                FileName = command.FileName
            });
        }
    }
}
