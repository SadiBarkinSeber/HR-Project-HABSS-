using HR_PROJECT.Application.Features.CQRS.Queries.AdvanceQueries;
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
    public class GetAdvanceByIdQueryHandler
    {
        private readonly IRepository<Advance> _repository;

        public GetAdvanceByIdQueryHandler(IRepository<Advance> repository)
        {
            _repository = repository;
        }

        public async Task<GetAdvanceByIdQueryResult> Handle(GetAdvanceByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);
            return new GetAdvanceByIdQueryResult
            {
                Id = values.Id,
                AdvanceType = values.AdvanceType,
                Amount = values.Amount,
                ApprovalStatus = values.ApprovalStatus,
                RequestDate = values.RequestDate,
                Response = values.Response,
                Currency = values.Currency,
                Permission = values.Permission,
                EmployeeId = values.EmployeeId,
                Description = values.Description,
            };

        }
    }
}
