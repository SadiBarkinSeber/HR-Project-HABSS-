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
    public class ExpenseRepository : Repository<Expense>, IExpenseRepository
    {

        private readonly HRProjectContext _context;

        public ExpenseRepository(HRProjectContext context) : base(context) 
        {
            _context = context;
        }


        public async Task<List<Expense>> GetExpensesByEmployeeId(int id)
        {
            var expenses = await _context.Expenses
                .Where(e => e.EmployeeId == id)
                .ToListAsync();

            return expenses;
        }
    }
}
