using HR_PROJECT.Application.Features.CQRS.Results.EmployeeResults;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read
{
    public class GetEmployeeQueryHandler
    {
        private readonly IRepository<Employee> _repository;

        public GetEmployeeQueryHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<List<GetEmployeeQueryResult>> Handle()
        {
            var values = await _repository.GetAllAsync();
            return values.Select(x => new GetEmployeeQueryResult
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
                Gender = x.Gender,

            }).ToList();
        }
    }
}
