using HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Queries.AdvanceQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.WebAPI.HelperFunctions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    //[Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AdvancesController : ControllerBase
    {
        #region Advance Handlers

        private readonly CreateAdvanceCommandHandler _createAdvanceCommandhandler;
        private readonly GetAdvanceByIdQueryHandler _getAdvanceByIdQueryHandler;
        private readonly GetAdvanceQueryHandler _getAdvanceQueryHandler;
        private readonly UpdateAdvanceCommandHandler _updateAdvanceCommandhandler;
        private readonly RemoveAdvanceCommandHandler _removeAdvanceCommandHandler;
        private readonly GetAdvanceByEmployeeIdQueryHandler _getAdvanceByEmployeeIdQueryHandler;
        private readonly GetEmployeeByIdQueryHandler _getEmployeeByIdQueryHandler;
        private readonly UpdateAdvanceForEmployeeCommandHandler _updateAdvanceForEmployeeCommandHandler;
        #endregion

        #region Helper Functions
        private readonly CheckEmployeeWage _checkEmployeeWage;
        #endregion

        #region Constructor

        public AdvancesController(CreateAdvanceCommandHandler createAdvanceCommandHandler, GetAdvanceByIdQueryHandler getAdvanceByIdQueryHandler, GetAdvanceQueryHandler getAdvanceQueryHandler, UpdateAdvanceCommandHandler updateAdvanceCommandHandler, RemoveAdvanceCommandHandler removeAdvanceCommandHandler, CheckEmployeeWage checkEmployeeWage, GetAdvanceByEmployeeIdQueryHandler getAdvanceByEmployeeIdQueryHandler, GetEmployeeByIdQueryHandler getEmployeeByIdQueryHandler, UpdateAdvanceForEmployeeCommandHandler updateAdvanceForEmployeeCommandHandler)
        {
            _createAdvanceCommandhandler = createAdvanceCommandHandler;
            _getAdvanceByIdQueryHandler = getAdvanceByIdQueryHandler;
            _getAdvanceQueryHandler = getAdvanceQueryHandler;
            _updateAdvanceCommandhandler = updateAdvanceCommandHandler;
            _removeAdvanceCommandHandler = removeAdvanceCommandHandler;
            _getAdvanceByEmployeeIdQueryHandler = getAdvanceByEmployeeIdQueryHandler;
            _checkEmployeeWage = checkEmployeeWage;
            _getEmployeeByIdQueryHandler = getEmployeeByIdQueryHandler;
            _updateAdvanceForEmployeeCommandHandler = updateAdvanceForEmployeeCommandHandler;
        }

        #endregion

        #region Read Methods

        //[Authorize(Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> AdvanceList()
        {
            var values = await _getAdvanceQueryHandler.Handle();
            return Ok(values);
        }

        //[Authorize(Roles = "manager")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdvance(int id)
        {
            var value = await _getAdvanceByIdQueryHandler.Handle(new GetAdvanceByIdQuery(id));
            return Ok(value);
        }

        //[Authorize(Roles = "employee")]
        [HttpGet("{employeeId}/byEmployee")]
        public async Task<IActionResult> GetAdvancesByEmployee(int employeeId)
        {
            var values = await _getAdvanceByEmployeeIdQueryHandler.Handle(new GetAdvancesByEmployeeIdQuery(employeeId));
            return Ok(values);
        }

        #endregion

        #region Write Methods

        //[Authorize(Roles = "employee")]
        [HttpPost]
        public async Task<IActionResult> CreateAdvance(CreateAdvanceCommand command)
        {
            try
            {
                 await _getEmployeeByIdQueryHandler.Handle(new GetEmployeeByIdQuery(command.EmployeeId));
                var isAmountValid = await _checkEmployeeWage.Helper(new GetEmployeeByIdQuery(command.EmployeeId), command.AmountValue);
                if (!isAmountValid)
                {
                    return BadRequest("Talep edilen avans miktarı maaşın 3 katından fazla olduğu için talep edilemez.");
                }

                await _createAdvanceCommandhandler.Handle(command);

                return Ok("Avans bilgisi eklendi.");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        //[Authorize(Roles = "manager")]
        [HttpDelete]
        public async Task<IActionResult> RemoveAdvance(int id)
        {
            await _removeAdvanceCommandHandler.Handle(new RemoveAdvanceCommand(id));
            return Ok("Avans bilgisi silindi.");
        }

        //[Authorize(Roles = "manager")]
        [HttpPut]
        public async Task<IActionResult> UpdateAdvance(UpdateAdvanceCommand command)
        {
            try
            {
                await _updateAdvanceCommandhandler.Handle(command);
                return Ok("Avans bilgisi güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut("employee")]
        public async Task<IActionResult> UpdateAdvanceForEmployee(UpdateAdvanceForEmployeeCommand command)
        {
            try
            {
                await _updateAdvanceForEmployeeCommandHandler.Handle(command);
                return Ok("Avans bilgisi güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion

    }
}
