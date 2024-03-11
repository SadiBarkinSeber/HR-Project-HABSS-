using HR_PROJECT.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read
{
    public class GetEmployeePhotoHandler
    {
        private readonly IBlobRepository _blobRepository;
        
        public GetEmployeePhotoHandler(IBlobRepository blobRepository)
        {
            _blobRepository = blobRepository;
        }

        
    }
}
