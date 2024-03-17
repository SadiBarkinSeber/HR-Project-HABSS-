using HR_PROJECT.Application.Features.CQRS.Queries.AdvanceQueries;
using HR_PROJECT.Application.Features.CQRS.Results.AdvanceResults;
using HR_PROJECT.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Read
{
    public class GetAdvanceByEmployeeIdQueryHandler
    {
        private readonly IAdvanceRepository _advanceRepository;

        public GetAdvanceByEmployeeIdQueryHandler(IAdvanceRepository advanceRepository)
        {
            _advanceRepository = advanceRepository;
        }

        public async Task<List<GetAdvanceQueryResult>> Handle(GetAdvancesByEmployeeIdQuery query)
        {
            var values = await _advanceRepository.GetAllAdvancesByEmployeeID(query.Id);

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
                Description = x.Description
            }).ToList();
        }
    }
}
