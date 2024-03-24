using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.ManagerCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.ManagerHandlers.Write
{
    public class CreateManagerCommandHandler
    {
        private readonly IRepository<Manager> _repository;

        public CreateManagerCommandHandler(IRepository<Manager> repository)
        {
            _repository = repository;
        }


        public async Task Handle(CreateManagerCommand command)
        {
            await _repository.CreateAsync(new Manager
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
