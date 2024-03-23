using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.ExpenseCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.ExpenseHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.PermissionQueries;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    //[Authorize]
    public class PermissionController : ControllerBase
    {
        #region Permission Handlers

        private readonly CreatePermissionCommandHandler _createPermissionCommandHandler;
        private readonly GetPermissionsByEmployeeIDHandler _getPermissionsByEmployeeIDHandler;
        private readonly RemovePermissionCommandHandler _removePermissionCommandHandler;
        private readonly UpdatePermissionCommandHandler _updatePermissionCommandHandler;
        private readonly GetPermissionQueryHandler _getPermissionQueryHandler;
        private readonly GetEmployeeByIdQueryHandler _getEmployeeByIdQueryHandler;
        private readonly UpdatepermissionForEmployeeCommandHandler _updatePermissionForEmployeeCommandHandler;
        #endregion


        #region Constructor

       public PermissionController(CreatePermissionCommandHandler createPermissionCommandHandler, GetPermissionsByEmployeeIDHandler getPermissionsByEmployeeIDHandler, RemovePermissionCommandHandler removePermissionCommandHandler, UpdatePermissionCommandHandler updatePermissionCommandHandler, GetPermissionQueryHandler getPermissionQueryHandler, GetEmployeeByIdQueryHandler getEmployeeByIdQueryHandler, UpdatepermissionForEmployeeCommandHandler updatepermissionForEmployeeCommandHandler)
        {
            _createPermissionCommandHandler = createPermissionCommandHandler;
            _getPermissionsByEmployeeIDHandler = getPermissionsByEmployeeIDHandler;
            _removePermissionCommandHandler = removePermissionCommandHandler;
            _updatePermissionCommandHandler = updatePermissionCommandHandler; 
            _getPermissionQueryHandler = getPermissionQueryHandler;
            _getEmployeeByIdQueryHandler = getEmployeeByIdQueryHandler;
            _updatePermissionForEmployeeCommandHandler = updatepermissionForEmployeeCommandHandler;
        }
        #endregion


        #region Read Methods

        //[Authorize(Roles = "employee")]
        [HttpGet("{employeeId}/byEmployee")]
        public async Task<IActionResult> GetPermissionsByEmployee(int employeeId)
        {
            var value = await _getPermissionsByEmployeeIDHandler.Handle(new GetPermissionsByEmployeeIDQuery(employeeId));
            return Ok(value);
        }

        //[Authorize(Roles = "manager")]
        [HttpGet]
        public async Task<IActionResult> GetPermissions()
        {
            var values = await _getPermissionQueryHandler.Handle();
            return Ok(values);
        }
        #endregion


        #region Write Methods

        //[Authorize(Roles = "employee")]
        [HttpPost]
        public async Task<IActionResult> CreatePermission(CreatePermissionCommand command)
        {
            try
            {
                await _getEmployeeByIdQueryHandler.Handle(new GetEmployeeByIdQuery(command.EmployeeId));
                await _createPermissionCommandHandler.Handle(command);
                
                return Ok("Izin talebi basarili bir sekilde gonderildi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        //[Authorize(Roles = "manager")]
        [HttpDelete]
        public async Task<IActionResult> RemovePermission(int id)
        {
            await _removePermissionCommandHandler.Handle(new RemovePermissionCommand(id));
            return Ok("Izin talebi basarili bir sekilde  silindi.");
        }

        //[Authorize(Roles = "manager")]
        [HttpPut]
        public async Task<IActionResult> UpdatePermission(UpdatePermissionCommand command)
        {
            try
            {
                await _updatePermissionCommandHandler.Handle(command);
                return Ok("Izin talebi basarili bir sekilde güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpPut("employee")]
        public async Task<IActionResult> UpdatePermissionForEmplyoee(UpdatePermissionForEmployeeCommand command)
        {
            try
            {
                await _updatePermissionForEmployeeCommandHandler.Handle(command);
                return Ok("İzin talebi güncellendi.");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
        }

        #endregion
    }


}
