using HR_PROJECT.Application.Features.CQRS.Queries.CompanyQueries;
using HR_PROJECT.Application.Features.CQRS.Results.CompanyResults;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.CompanyHandlers.Read
{
    public class GetCompanyByIdQueryHandler
    {
        private readonly IRepository<Company> _repository;

        public GetCompanyByIdQueryHandler(IRepository<Company> repository)
        {
            _repository = repository;
        }

        public async Task<GetCompanyQueryResult> Handle(GetCompanyByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);

            if (values == null)
            {
                throw new Exception("Company does not exist.");
            }

            return new GetCompanyQueryResult
            {
                Id = values.Id,
                Name = values.Name,
                Title = values.Title,
                MersisNo = values.MersisNo,
                TaxNumber = values.TaxNumber,
                TaxDepartment = values.TaxDepartment,
                PhoneNumber = values.PhoneNumber,
                LogoImagePath = values.LogoImagePath,
                Address = values.Address,
                Email = values.Email,
                EmployeeCount = values.EmployeeCount,
                FoundingDate = values.FoundingDate,
                DealStartDate = values.DealStartDate,
                DealEndDate = values.DealEndDate,
                IsActive = values.IsActive
            };
        }
    }
}
