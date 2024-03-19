using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class EmployeesController : ControllerBase
    {
        #region Employee Handlers
        private readonly CreateEmployeeCommandHandler _createEmployeeCommandHandler;
        private readonly GetEmployeeByIdQueryHandler _getEmployeeByIdQueryHandler;
        private readonly GetEmployeeQueryHandler _getEmployeeQueryHandler;
        private readonly UpdateEmployeeCommandHandler _updateEmployeeCommandHandler;
        private readonly RemoveEmployeeCommandHandler _removeEmployeeCommandHandler;


        #endregion

        #region Constructor
        public EmployeesController(CreateEmployeeCommandHandler employeeCommandHandler, GetEmployeeByIdQueryHandler employeeByIdQueryHandler, GetEmployeeQueryHandler employeeQueryHandler, UpdateEmployeeCommandHandler updateEmployeeCommandHandler, RemoveEmployeeCommandHandler removeEmployeeCommandHandler)
        {
            _createEmployeeCommandHandler = employeeCommandHandler;
            _getEmployeeByIdQueryHandler = employeeByIdQueryHandler;
            _getEmployeeQueryHandler = employeeQueryHandler;
            _updateEmployeeCommandHandler = updateEmployeeCommandHandler;
            _removeEmployeeCommandHandler = removeEmployeeCommandHandler;
        }
        #endregion

        #region Read Methods

        [Authorize(Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> EmployeeList()
        {
            var values = await _getEmployeeQueryHandler.Handle();

            return Ok(values);
        }

        [Authorize(Roles = "employee")]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetEmployee(int id)
        {
            var value = await _getEmployeeByIdQueryHandler.Handle(new GetEmployeeByIdQuery(id));
            return Ok(value);
        }
        #endregion

        #region Write Methods

        [Authorize(Roles = "manager")]
        [HttpPost]
        public async Task<IActionResult> CreateEmployee(CreateEmployeeCommand command)
        {
            await _createEmployeeCommandHandler.Handle(command);
            return Ok("Çalışan bilgileri eklendi.");    
        }

        [Authorize(Roles = "manager")]
        [HttpDelete]
        public async Task<IActionResult> RemoveEmployee(int id)
        {
            await _removeEmployeeCommandHandler.Handle(new RemoveEmployeeCommand(id));

            return Ok("Çalışan silindi.");
        }

        [Authorize(Roles = "manager")]
        [HttpPut]
        public async Task<IActionResult> UpdateEmployee(UpdateEmployeeCommand command)
        {
            await _updateEmployeeCommandHandler.Handle(command);

            return Ok("Çalışan güncellendi.");
        }
        #endregion

    }
}
