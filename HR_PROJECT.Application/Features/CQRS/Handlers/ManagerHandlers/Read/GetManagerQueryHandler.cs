using HR_PROJECT.Application.Features.CQRS.Results.EmployeeResults;
using HR_PROJECT.Application.Features.CQRS.Results.ManagerResults;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.ManagerHandlers.Read
{
    public class GetManagerQueryHandler
    {
        private readonly IRepository<Manager> _repository;

        public GetManagerQueryHandler(IRepository<Manager> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetManagerQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetManagerQueryResult
            {
                Id = x.EmployeeId,
                FirstName = x.FirstName,
                SecondName = x.SecondName,
                FirstSurname = x.FirstSurname,
                SecondSurname = x.SecondSurname,
                DateOfBirth = x.DateOfBirth,
                BirthPlace = x.BirthPlace,
                Tc = x.Tc,
                StartDate = x.StartDate,
                EndDate = x.EndDate,
                IsActive = x.IsActive,
                Position = x.Position,
                Department = x.Department,
                Company = x.Company,
                Email = x.Email,
                Wage = x.Wage,
                ImagePath = x.ImagePath,
                PhoneNumber = x.PhoneNumber,
                Address = x.Address,
                UserId = x.UserId,

            }).ToList();
        }
    }
}

