using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write
{
    public class CreateEmployeeCommandHandler
    {
        private readonly IRepository<Employee> _repository;

        public CreateEmployeeCommandHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }


        public async Task Handle(CreateEmployeeCommand command)
        {
            await _repository.CreateAsync(new Employee
            {
                FirstName = command.FirstName,
                SecondName = command.SecondName,
                FirstSurname = command.FirstSurname,
                SecondSurname = command.SecondSurname,
                DateOfBirth = command.DateOfBirth,
                BirthPlace = command.BirthPlace,
                Tc = command.Tc,
                StartDate = command.StartDate,
                EndDate = command.EndDate,
                IsActive = command.IsActive,
                Position = command.Position,
                Department = command.Department,
                Company = command.Company,
                Email = command.Email,
                Wage = command.Wage,
                ImagePath = command.ImagePath,
                PhoneNumber = command.PhoneNumber,
                Address = command.Address,
                UserId = command.UserId
            });
        }
    }
}
