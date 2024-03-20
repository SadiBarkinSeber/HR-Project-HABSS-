using HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Write;
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
        #endregion

        #region Helper Functions
        private readonly CheckEmployeeWage _checkEmployeeWage;
        #endregion

        #region Constructor

        public AdvancesController(CreateAdvanceCommandHandler createAdvanceCommandHandler, GetAdvanceByIdQueryHandler getAdvanceByIdQueryHandler, GetAdvanceQueryHandler getAdvanceQueryHandler, UpdateAdvanceCommandHandler updateAdvanceCommandHandler, RemoveAdvanceCommandHandler removeAdvanceCommandHandler, CheckEmployeeWage checkEmployeeWage, GetAdvanceByEmployeeIdQueryHandler getAdvanceByEmployeeIdQueryHandler)
        {
            _createAdvanceCommandhandler = createAdvanceCommandHandler;
            _getAdvanceByIdQueryHandler = getAdvanceByIdQueryHandler;
            _getAdvanceQueryHandler = getAdvanceQueryHandler;
            _updateAdvanceCommandhandler = updateAdvanceCommandHandler;
            _removeAdvanceCommandHandler = removeAdvanceCommandHandler;
            _getAdvanceByEmployeeIdQueryHandler = getAdvanceByEmployeeIdQueryHandler;
            _checkEmployeeWage = checkEmployeeWage;
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
            var value = await _checkEmployeeWage.Helper(new GetEmployeeByIdQuery(command.EmployeeId), command.Amount);

            if (!value)
            {
                return BadRequest("The requested advance amount exceeds the allowed limit. Please select an amount that is lesser than the 3 times value of the requesting employees wage.");
            }

            await _createAdvanceCommandhandler.Handle(command);
            return Ok("Avans bilgisi eklendi.");
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
            await _updateAdvanceCommandhandler.Handle(command);
            return Ok("Avans bilgisi güncellendi.");
        }

        #endregion

    }
}
