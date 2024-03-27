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
    public class UpdateApplicationuserCommandHandler
    {
        private readonly IAplicationUserRepository _userRepository;
        private readonly IRepository<ApplicationUser> _repository;
        public UpdateApplicationuserCommandHandler(IAplicationUserRepository userRepository, IRepository<ApplicationUser> repository)
        {
            _userRepository = userRepository;
            _repository = repository;

        }
        public async Task Handle(UpdateApplicationUserCommand command)
        {
            var values = await _userRepository.GetUserById(command.Id);

            values.OneTimePassword = command.OneTimePassword;

            await _repository.UpdateAsync(values);
        }
    }
}
