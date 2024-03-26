using HR_PROJECT.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HR_PROJECT.Application.Interfaces
{
    public interface IAdvanceRepository
    {
        Task<List<Advance>> GetAllAdvancesByEmployeeID(int id);
        Task<List<Advance>> GetAdvancesWithEmployees();
    }
}
