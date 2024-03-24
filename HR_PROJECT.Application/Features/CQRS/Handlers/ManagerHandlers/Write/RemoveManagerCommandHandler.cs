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
    public class RemoveManagerCommandHandler
    {
        private readonly IRepository<Manager> _repository;

        public RemoveManagerCommandHandler(IRepository<Manager> repository)
        {
            _repository = repository;
        }

        public async Task Handle(RemoveManagerCommand command)
        {
            var value = await _repository.GetByIdAsync(command.Id);
            await _repository.RemoveAsync(value);
        }
    }
}
