using HR_PROJECT.Application.Features.CQRS.Commands.CompanyCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.CompanyHandlers.Write
{
    public class CreateCompanyCommandHandler 
    {
        private readonly IRepository<Company> _companyRepository;

        public CreateCompanyCommandHandler(IRepository<Company> companyRepository)
        {
            _companyRepository = companyRepository;
        }

        public async Task Handle(CreateCompanyCommand command)
        {
            await _companyRepository.CreateAsync(new Company
            {
                Name = command.Name,
                Title = command.Title,
                MersisNo = command.MersisNo,
                TaxNumber = command.TaxNumber,
                TaxDepartment = command.TaxDepartment,
                PhoneNumber = command.PhoneNumber,
                LogoImagePath = command.LogoImagePath,
                Address = command.Address,
                Email = command.Email,
                EmployeeCount = command.EmployeeCount,
                FoundingDate = command.FoundingDate,
                DealStartDate = command.DealStartDate,
                DealEndDate = command.DealEndDate,
                IsActive = command.IsActive
            });
        }
    }
}
