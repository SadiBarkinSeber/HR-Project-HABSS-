using HR_PROJECT.Application.Features.CQRS.Commands.SiteManagerCommands;
using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.SiteManagerHandlers.Write
{
    public class UpdateSiteManagerCommandHandler
    {
        private readonly IRepository<SiteManager> _repository;

        public UpdateSiteManagerCommandHandler(IRepository<SiteManager> repository)
        {
            _repository = repository;
        }

        public async Task Handle(UpdateSiteManagerCommand command)
        {
            var values = await _repository.GetByIdAsync(command.Id);

            values.PhoneNumber = command.Phonenumber;
            values.Address = command.Address;
            values.ImagePath = command.ImagePath;

            await _repository.UpdateAsync(values);
        }
    }
}
