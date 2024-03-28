using HR_PROJECT.Application.Features.CQRS.Commands.CompanyCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.CompanyHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.CompanyHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.CompanyQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CompanyController : ControllerBase
    {
        #region Company Handlers

        private readonly GetCompanyByIdQueryHandler _getCompanyByIdQueryHandler;
        private readonly GetCompanyQueryHandler _getCompanyQueryHandler;
        private readonly CreateCompanyCommandHandler _createCompanyCommandHandler;

        #endregion

        #region Constructor
        public CompanyController(GetCompanyByIdQueryHandler getCompanyByIdQueryHandler, GetCompanyQueryHandler getCompanyQueryHandler, CreateCompanyCommandHandler createCompanyCommandHandler)
        {
            _createCompanyCommandHandler = createCompanyCommandHandler;
            _getCompanyByIdQueryHandler = getCompanyByIdQueryHandler;
            _getCompanyQueryHandler = getCompanyQueryHandler;
        }
        #endregion

        #region Read

        [HttpGet]
        public async Task<IActionResult> GetCompanies()
        {
            try
            {
                var values = await _getCompanyQueryHandler.Handle();
                return Ok(values);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
            
        }


        [HttpGet("{id}")]
        public async Task<IActionResult> GetCompany(int id)
        {
            try
            {
                var value = await _getCompanyByIdQueryHandler.Handle(new GetCompanyByIdQuery(id));
                return Ok(value);
            }
            catch (Exception ex1) 
            {
                return BadRequest(ex1.Message);
            }
        }

        #endregion


        #region Write

        [HttpPost]
        public async Task<IActionResult> CreateCompany(CreateCompanyCommand command)
        {
            try
            {
                await _createCompanyCommandHandler.Handle(command);
                return Ok("Şirket bilgileri eklendi.");
            }
            catch (Exception ex) 
            {
                return BadRequest(ex.Message);
            }
            
        }

        #endregion
    }
}
