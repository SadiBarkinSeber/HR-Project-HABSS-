using HR_PROJECT.Application.Features.CQRS.Queries.SiteManagetQueries;
using HR_PROJECT.Application.Features.CQRS.Results.SiteManagerResults;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.SiteManagerHandlers.Read
{
    public class GetSiteManagerByIdQueryHandler
    {
        private readonly IRepository<SiteManager> _repository;

        public GetSiteManagerByIdQueryHandler(IRepository<SiteManager> repository)
        {
            _repository = repository;
        }

        public async Task<GetSiteManagerByIdQueryResult> Handle(GetSiteManagerByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);

            if (values == null)
            {
                throw new Exception("Site manager does not exists.");
            }

            return new GetSiteManagerByIdQueryResult
            {
                Id = values.EmployeeId,
                FirstName= values.FirstName,
                SecondName = values.SecondName,
                FirstSurname = values.FirstSurname,
                SecondSurname = values.SecondSurname,
                DateOfBirth = values.DateOfBirth,
                BirthPlace = values.BirthPlace,
                Tc = values.Tc,
                StartDate = values.StartDate,
                EndDate = values.EndDate,
                IsActive = values.IsActive,
                Position = values.Position,
                Department = values.Department,
                Company = values.Company,
                Email = values.Email,
                Wage = values.Wage,
                ImagePath = values.ImagePath,
                PhoneNumber = values.PhoneNumber,
                Address = values.Address
            };
        }
    }
}
