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
    public class UpdateEmployeeCommandHandler
    {
        private readonly IRepository<Employee> _repository;

        public UpdateEmployeeCommandHandler(IRepository<Employee> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateEmployeeCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.FirstName = command.FirstName;
            values.SecondName = command.SecondName;
            values.FirstSurname = command.FirstSurname;
            values.SecondSurname = command.SecondSurname;
            values.DateOfBirth = command.DateOfBirth;
            values.BirthPlace = command.BirthPlace;
            values.Tc = command.Tc;
            values.StartDate = command.StartDate;
            values.EndDate = command.EndDate;
            values.IsActive = command.IsActive;
            values.Position = command.Position;
            values.Department = command.Department;
            values.Company = command.Company;
            values.Mail = command.Mail;
            values.Wage = command.Wage;
            values.ImagePath = command.ImagePath;
            values.PhoneNumber = command.PhoneNumber;

            await _repository.UpdateAsync(values);
        }
    }
}
