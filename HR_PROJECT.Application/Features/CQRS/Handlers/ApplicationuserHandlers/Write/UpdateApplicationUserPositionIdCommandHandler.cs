using HR_PROJECT.Application.Features.CQRS.Commands.ApplicationUserCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.ApplicationuserHandlers.Write
{
    public class UpdateApplicationUserPositionIdCommandHandler
    {
        private readonly IRepository<ApplicationUser> _repository;
        private readonly IAplicationUserRepository _userRepository;

        public UpdateApplicationUserPositionIdCommandHandler(IRepository<ApplicationUser> repository, IAplicationUserRepository userRepository)
        {
            _repository = repository;
            _userRepository = userRepository;

        }

        public async Task Handle(UpdateApplicationUserPositionIdCommand command)
        {
            var user = await _userRepository.GetUserById(command.Id);

            if (command.RoleName == "employee")
            {
                user.EmployeeId = command.PositionId;
            }

            if (command.RoleName == "manager")
            {
                user.ManagerId = command.PositionId;
            }

            await _repository.UpdateAsync(user);
        }
    }
}
