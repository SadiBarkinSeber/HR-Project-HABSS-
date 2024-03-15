using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.PermissionComands;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.PermissionHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.PermissionQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Identity.Client;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PermissionController : ControllerBase
    {
        #region Permission Handlers

        private readonly CreatePermissionCommandHandler _createPermissionCommandHandler;
        private readonly GetPermissionsByEmployeeIDHandler _getPermissionsByEmployeeIDHandler;

        #endregion


        #region Constructor

        public PermissionController(CreatePermissionCommandHandler createPermissionCommandHandler, GetPermissionsByEmployeeIDHandler getPermissionsByEmployeeIDHandler)
        {
            _createPermissionCommandHandler = createPermissionCommandHandler;
            _getPermissionsByEmployeeIDHandler = getPermissionsByEmployeeIDHandler;
        }
        #endregion

   
        #region Read Methods

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPermissions(int id)
        {
            var value = await _getPermissionsByEmployeeIDHandler.Handle(new GetPermissionsByEmployeeIDQuery(id));
            return Ok(value);
        }
        #endregion


        #region Write Methods

        [HttpPost]
        public async Task<IActionResult> CreatePermission(CreatePermissionCommand command)
        {
            await _createPermissionCommandHandler.Handle(command);
            return Ok("Izin talebi basarili bir sekilde gonderildi.");
        }
        #endregion
    }


}
