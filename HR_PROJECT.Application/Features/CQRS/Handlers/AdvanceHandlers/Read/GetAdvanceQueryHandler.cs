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
        private readonly IAdvanceRepository _advanceRepository;

        public GetAdvanceQueryHandler(IAdvanceRepository repository)
        {
            _advanceRepository = repository;
        }

        public async Task<List<GetAdvanceQueryResult>> Handle()
        {
            var values = await _advanceRepository.GetAdvancesWithEmployees();
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
                AmountValue = x.AmountValue,
                EmployeeFirstName = x.Employee.FirstName,
                EmployeeSecondName = x.Employee.SecondName,
                EmployeeLastName = x.Employee.FirstSurname,
                EmployeeSecondLastName = x.Employee.SecondSurname
            }).ToList();
        }
    }
}
