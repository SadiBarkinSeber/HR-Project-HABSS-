using HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.ExpenseQueries;
using HR_PROJECT.Application.Features.CQRS.Results.EmployeeResults;
using HR_PROJECT.WebAPI.HelperFunctions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ExpensesController : ControllerBase
    {
        #region Expense Handlers

        private readonly CreateExpenseCommandHandler _createExpenseCommandhandler;
        private readonly GetExpenseByIdQueryHandler _getExpenseByIdQueryHandler;
        private readonly GetExpenseQueryHandler _getExpenseQueryHandler;
        private readonly UpdateExpenseCommandHandler _updateExpenseCommandhandler;
        private readonly RemoveExpenseCommandHandler _removeExpenseCommandHandler;
        private readonly GetExpenseByEmployeeIdQueryHandler _getExpensesByEmployee;
        private readonly GetEmployeeByIdQueryHandler _getEmployeeByIdQueryHandler;
        
        #endregion

        #region Constructor

        public ExpensesController(CreateExpenseCommandHandler createExpenseCommandHandler, GetExpenseByIdQueryHandler getExpenseByIdQueryHandler, GetExpenseQueryHandler getExpenseQueryHandler, UpdateExpenseCommandHandler updateExpenseCommandHandler, RemoveExpenseCommandHandler removeExpenseCommandHandler, GetExpenseByEmployeeIdQueryHandler getExpensesByEmployee, GetEmployeeByIdQueryHandler getEmployeeByIdQueryHandler)
        {
            _createExpenseCommandhandler = createExpenseCommandHandler;
            _getExpenseByIdQueryHandler = getExpenseByIdQueryHandler;
            _getExpenseQueryHandler = getExpenseQueryHandler;
            _updateExpenseCommandhandler = updateExpenseCommandHandler;
            _removeExpenseCommandHandler = removeExpenseCommandHandler;
            _getExpensesByEmployee = getExpensesByEmployee;
            _getEmployeeByIdQueryHandler = getEmployeeByIdQueryHandler;
        }

        #endregion


        #region Read Methods

        [HttpGet]
        public async Task<IActionResult> GetExpenses()
        {
            var values = await _getExpenseQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetExpenseById(int id)
        {
            try
            {
                var value = await _getExpenseByIdQueryHandler.Handle(new GetExpenseByIdQuery(id));
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpGet("{employeeId}/byEmployee")]
        public async Task<IActionResult> GetExpensesByEmployee(int employeeId)
        {
            
            var expenses = await _getExpensesByEmployee.Handle(new GetExpensesByEmployeeIdQuery(employeeId));

            if (expenses == null)
            {
                return NotFound();
            }

            return Ok(expenses);

        }

        #endregion

        #region Write Methods

        [HttpPost]
        public async Task<IActionResult> CreateExpense(CreateExpenseCommand command)
        {
            try
            {
                await _getEmployeeByIdQueryHandler.Handle(new GetEmployeeByIdQuery(command.EmployeeId));
                await _createExpenseCommandhandler.Handle(command);
                return Ok("Harcama bilgisi eklendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveExpense(int id)
        {
            await _removeExpenseCommandHandler.Handle(new RemoveExpenseCommand(id));
            return Ok("Harcama bilgisi silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateExpense(UpdateExpenseCommand command)
        {
            await _updateExpenseCommandhandler.Handle(command);
            return Ok("Harcama bilgisi güncellendi.");
        }

        #endregion

    }
}
