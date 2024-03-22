using HR_PROJECT.Application.Features.CQRS.Results.EmployeeResults;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read
{
    public class GetEmployeeByIdQueryHandler
    {
        private readonly IRepository<Employee> _repository;

        public GetEmployeeByIdQueryHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task<GetEmployeeByIdQueryResult> Handle(GetEmployeeByIdQuery query)
        {
            var values = await _repository.GetByIdAsync(query.Id);

            if (values == null) 
            {
                throw new Exception("Employee does not exists.");
            }

            return new GetEmployeeByIdQueryResult
            {
                Id = values.EmployeeId,
                FirstName = values.FirstName,
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
                Address = values.Address,
                
            };
        }

    }
}
