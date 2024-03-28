using HR_PROJECT.Application.Features.CQRS.Commands.SiteManagerCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.SiteManagerHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.SiteManagerHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.SiteManagetQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SiteManagerController : ControllerBase
    {
        #region SiteManager Handlers

        private readonly GetSiteManagerByIdQueryHandler _siteManagerByIdQueryHandler;
        private readonly UpdateSiteManagerCommandHandler _updateSiteManagerCommandHandler;

        #endregion

        #region Constructor

        public SiteManagerController(GetSiteManagerByIdQueryHandler siteManagerByIdQueryHandler, UpdateSiteManagerCommandHandler updateSiteManagerCommandHandler)
        {
            _siteManagerByIdQueryHandler = siteManagerByIdQueryHandler;
            _updateSiteManagerCommandHandler = updateSiteManagerCommandHandler;
        }

        #endregion


        #region Read

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSiteManager(int id)
        {
            try
            {
                var value = await _siteManagerByIdQueryHandler.Handle(new GetSiteManagerByIdQuery(id));
                return Ok(value);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        #endregion

        #region Write

        [HttpPut]
        public async Task<IActionResult> UpdateSiteManager(UpdateSiteManagerCommand command)
        {
            try
            {
                await _updateSiteManagerCommandHandler.Handle(command);
                return Ok("Site yöneticisi güncellendi.");
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }

        #endregion
    }
}
