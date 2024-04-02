using HR_PROJECT.Application.Features.CQRS.Queries.ExpenseQueries;
using HR_PROJECT.Application.Features.CQRS.Results.ExpenseResults;
using HR_PROJECT.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Read
{
    public class GetExpenseByEmployeeIdQueryHandler
    {
        private readonly IExpenseRepository _expenseRepository;

        public GetExpenseByEmployeeIdQueryHandler(IExpenseRepository expenseRepository)
        {
            _expenseRepository = expenseRepository;
        }

        public async Task<List<GetExpenseQueryResult>> Handle(GetExpensesByEmployeeIdQuery query)
        {
            var values = await _expenseRepository.GetExpensesByEmployeeId(query.Id);

            return values.Select(x => new GetExpenseQueryResult
            {
                Id = x.Id,
                EmployeeId = x.EmployeeId,
                ExpenseType = x.ExpenseType,
                Amount = x.Amount,
                ApprovalStatus = x.ApprovalStatus,
                RequestDate = x.RequestDate,
                Response = x.Response,
                Currency = x.Currency,
                Permission = x.IsApproved,
                FileName = x.FileName
            }).ToList();
        } 
    }
}
