using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using Microsoft.AspNetCore.Identity;
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
        private readonly UserManager<ApplicationUser> _userManager;

        public CreateEmployeeCommandHandler(IRepository<Employee> repository, UserManager<ApplicationUser> userManager)
        {
            _repository = repository;
            _userManager = userManager;
        }


        public async Task<int> Handle(CreateEmployeeCommand command)
        {
            var user = await _userManager.FindByIdAsync(command.UserId);
            Employee employee = new Employee()
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
            await _repository.CreateAsync(employee);

            int id = employee.EmployeeId;

            return id;
        }
    }
}
