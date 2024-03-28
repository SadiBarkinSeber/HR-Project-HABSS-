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
    public class GetCompanyQueryHandler
    {
        private readonly IRepository<Company> _repository;
        public GetCompanyQueryHandler(IRepository<Company> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetCompanyQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();

            return values.Select(x => new GetCompanyQueryResult
            {
                Id = x.Id,
                Name = x.Name,
                Title = x.Title,
                MersisNo = x.MersisNo,
                TaxNumber = x.TaxNumber,
                TaxDepartment = x.TaxDepartment,
                PhoneNumber = x.PhoneNumber,
                LogoImagePath = x.LogoImagePath,
                Address = x.Address,
                Email = x.Email,
                EmployeeCount = x.EmployeeCount,
                FoundingDate = x.FoundingDate,
                DealStartDate = x.DealStartDate,
                DealEndDate = x.DealEndDate,
                IsActive = x.IsActive,
            }).ToList();
        }
    }
}
