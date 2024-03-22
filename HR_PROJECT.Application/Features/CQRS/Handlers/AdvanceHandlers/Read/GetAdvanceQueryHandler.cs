using HR_PROJECT.Application.Features.CQRS.Results.AdvanceResults;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Read
{
    public class GetAdvanceQueryHandler
    {
        private readonly IRepository<Advance> _repository;

        public GetAdvanceQueryHandler(IRepository<Advance> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetAdvanceQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetAdvanceQueryResult
            {
                Id = x.Id,
                AdvanceType = x.AdvanceType,
                Amount = x.Amount,
                ApprovalStatus = x.ApprovalStatus,
                RequestDate = x.RequestDate,
                Response = x.Response,
                Currency = x.Currency,
                Permission = x.Permission,
                EmployeeId = x.EmployeeId,
                Description = x.Description,
                AmountValue = x.AmountValue
            }).ToList();
        }
    }
}
