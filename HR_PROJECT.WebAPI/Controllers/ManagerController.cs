using HR_PROJECT.Application.Features.CQRS.Commands.ApplicationUserCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.EmployeeCommands;
using HR_PROJECT.Application.Features.CQRS.Commands.ManagerCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.ApplicationuserHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.EmployeeHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Handlers.ManagerHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.ManagerHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.EmployeeQueries;
using HR_PROJECT.Application.Features.CQRS.Queries.ManagerQueries;
using HR_PROJECT.WebAPI.DTOs.ApplicationUserDTOs;
using HR_PROJECT.WebAPI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerController : ControllerBase
    {
        #region Manager Handlers
        private readonly CreateManagerCommandHandler _createManagerCommandHandler;
        private readonly GetManagerByIdQueryHandler _getManagerByIdQueryHandler;
        private readonly GetManagerQueryHandler _getManagerQueryHandler;
        private readonly UpdateManagerCommandHandler _updateManagerCommandHandler;
        private readonly RemoveManagerCommandHandler _removeManagerCommandHandler;
        private readonly IAuthService _authService;
        private readonly UpdateApplicationUserPositionIdCommandHandler _updateManagerId;


        #endregion

        #region Constructor
        public ManagerController(CreateManagerCommandHandler managerCommandHandler, GetManagerByIdQueryHandler managerByIdQueryHandler, GetManagerQueryHandler managerQueryHandler, UpdateManagerCommandHandler updateManagerCommandHandler, RemoveManagerCommandHandler removeManagerCommandHandler, IAuthService authService, UpdateApplicationUserPositionIdCommandHandler updateManagerId)
        {
            _createManagerCommandHandler = managerCommandHandler;
            _getManagerByIdQueryHandler = managerByIdQueryHandler;
            _getManagerQueryHandler = managerQueryHandler;
            _updateManagerCommandHandler = updateManagerCommandHandler;
            _removeManagerCommandHandler = removeManagerCommandHandler;
            _authService = authService;
            _updateManagerId = updateManagerId;
        }
        #endregion

        #region Read Methods

        [HttpGet]
        public async Task<IActionResult> ManagerList()
        {
            var values = await _getManagerQueryHandler.Handle();

            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetManager(int id)
        {
            var value = await _getManagerByIdQueryHandler.Handle(new GetManagerByIdQuery(id));
            return Ok(value);
        }
        #endregion

        #region Write Methods

        [HttpPost]
        public async Task<IActionResult> CreateManager(CreateManagerCommand command)
        {
            CreateApplicationUserDTO dto = new CreateApplicationUserDTO()
            {
                Firstname = command.FirstName,
                Lastname = command.FirstSurname,
                UserName = command.FirstName.ToLower(),
                Role = "manager"
            };

            try
            {
                var (status, response) = await _authService.CreateUser(dto);
                if (!(status == 1))
                {
                    return BadRequest(response.Message);
                }

                command.UserId = response.Id;

                int managerId = await _createManagerCommandHandler.Handle(command);

                UpdateApplicationUserPositionIdCommand userCommand = new UpdateApplicationUserPositionIdCommand()
                {
                    Id = response.Id,
                    PositionId = managerId,
                    RoleName = "manager"
                };

                await _updateManagerId.Handle(userCommand);
                response.PositionId = managerId;

                return Ok(response);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveManager(int id)
        {
            await _removeManagerCommandHandler.Handle(new RemoveManagerCommand(id));

            return Ok("Yonetici silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateManager(UpdateManagerCommand command)
        {
            await _updateManagerCommandHandler.Handle(command);

            return Ok("Yonetici güncellendi.");
        }
        #endregion
    }
}
