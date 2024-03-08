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

            values.PhoneNumber = command.Phonenumber;
            values.Address = command.Address;

            await _repository.UpdateAsync(values);
        }
    }
}
