using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.ManagerCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateManagerCommandHandler(IRepository<Manager> repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }


        public async Task<int> Handle(CreateManagerCommand command)
        {

            var user = await _userManager.FindByIdAsync(command.UserId);

            Manager manager = new Manager()
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
                Email = user.Email,
                Wage = command.Wage,
                ImagePath = command.ImagePath,
                PhoneNumber = command.PhoneNumber,
                Address = command.Address,
                UserId = command.UserId,
                Gender = command.Gender
            };

            await _repository.CreateAsync(manager);

            int id = manager.EmployeeId;
            return id;
        }
    }
}
