using HR_PROJECT.Application.Interfaces;
using HR_PROJECT.Domain.Entities;
using HR_PROJECT.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Persistence.Repositories
{
    public class PermissionRepositoty : Repository<Permission>, IPermissionRepository
    {
        private readonly HRProjectContext _context;
        public PermissionRepositoty(HRProjectContext context) : base(context)
        {
            _context = context;
        }

        public async Task<List<Permission>> GetAllPermissionsByEmployeeID(int id)
        {
            var permissions = await _context.Permissions
            .Where(p => p.Id == id)
            .ToListAsync();

            return permissions;
        }
    }
}
