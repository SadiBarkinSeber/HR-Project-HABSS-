using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Interfaces
{
    public interface IAplicationUserRepository
    {
        Task<ApplicationUser> GetUserById(string id);
        

        
    }
}
