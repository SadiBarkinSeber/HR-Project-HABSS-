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
    public class UpdateManagerCommandHandler
    {
        private readonly IRepository<Manager> _repository;

        public UpdateManagerCommandHandler(IRepository<Manager> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateManagerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.PhoneNumber = command.Phonenumber;
            values.Address = command.Address;
            values.ImagePath = command.ImagePath;

            await _repository.UpdateAsync(values);
        }
    }
}
