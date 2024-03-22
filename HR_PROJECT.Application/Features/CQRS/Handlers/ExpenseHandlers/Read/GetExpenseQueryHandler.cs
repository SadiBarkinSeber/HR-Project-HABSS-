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
    public class GetExpenseQueryHandler
    {
        private readonly IRepository<Expense> _repository;

        public GetExpenseQueryHandler(IRepository<Expense> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetExpenseQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetExpenseQueryResult
            {
                Id = x.Id,
                ExpenseType = x.ExpenseType,
                Amount = x.Amount,
                ApprovalStatus = x.ApprovalStatus,
                RequestDate = x.RequestDate,
                Response = x.Response,
                Currency = x.Currency,
                Permission = x.Permission,
                EmployeeId = x.EmployeeId,
                FileName = x.FileName,
                AmountValue = x.AmountValue,
            }).ToList();
        }
    }
}
