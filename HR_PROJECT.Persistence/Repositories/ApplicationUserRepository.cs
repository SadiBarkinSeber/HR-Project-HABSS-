using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using HR_PROJECT.Persistence.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Repositories
{
    public class ApplicationUserRepository : Repository<ApplicationUser>, IAplicationUserRepository
    {
        private readonly HRProjectContext _context;

        public ApplicationUserRepository(HRProjectContext context) : base(context) 
        {
            _context = context;
        }
        public async Task<ApplicationUser> GetUserById(string id)
        {
            return await _context.Set<ApplicationUser>().FindAsync(id);
        }
    }
}
