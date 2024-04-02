using HR_PROJECT.Application.Features.CQRS.Queries.ExpenseQueries;
using HR_PROJECT.Application.Features.CQRS.Results.ExpenseResults;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Read
{
    public class GetExpenseByIdQueryHandler
    {
        private readonly IRepository<Expense> _repository;

        public GetExpenseByIdQueryHandler(IRepository<Expense> repository)
        {
            _repository = repository;
        }

        public async Task<GetExpenseByIdQueryResult> Handle(GetExpenseByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);

            if (values == null)
            {
                throw new Exception("Expense not found.");
            }

            return new GetExpenseByIdQueryResult
            {
                Id = values.Id,
                ExpenseType = values.ExpenseType,
                Amount = values.Amount,
                ApprovalStatus = values.ApprovalStatus,
                RequestDate = values.RequestDate,
                Response = values.Response,
                Currency = values.Currency,
                Permission = values.IsApproved,
                EmployeeId = values.EmployeeId,
                FileName = values.FileName
                
            };
            
        }

    }
}
