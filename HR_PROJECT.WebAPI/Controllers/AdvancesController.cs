﻿using HR_PROJECT.Application.Features.CQRS.Commands.AdvanceCommands;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Read;
using HR_PROJECT.Application.Features.CQRS.Handlers.AdvanceHandlers.Write;
using HR_PROJECT.Application.Features.CQRS.Queries.AdvanceQueries;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HR_PROJECT.WebAPI.Controllers
{
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

        #endregion

        #region Constructor

        public AdvancesController(CreateAdvanceCommandHandler createAdvanceCommandHandler, GetAdvanceByIdQueryHandler getAdvanceByIdQueryHandler, GetAdvanceQueryHandler getAdvanceQueryHandler, UpdateAdvanceCommandHandler updateAdvanceCommandHandler, RemoveAdvanceCommandHandler removeAdvanceCommandHandler)
        {
            _createAdvanceCommandhandler = createAdvanceCommandHandler;
            _getAdvanceByIdQueryHandler = getAdvanceByIdQueryHandler;
            _getAdvanceQueryHandler = getAdvanceQueryHandler;
            _updateAdvanceCommandhandler = updateAdvanceCommandHandler;
            _removeAdvanceCommandHandler = removeAdvanceCommandHandler;
        }

        #endregion

        #region Read Methods

        [HttpGet]
        public async Task<IActionResult> AdvanceList()
        {
            var values = await _getAdvanceQueryHandler.Handle();
            return Ok(values);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAdvance(int id)
        {
            var value = await _getAdvanceByIdQueryHandler.Handle(new GetAdvanceByIdQuery(id));
            return Ok(value);
        }

        #endregion

        #region Write Methods

        [HttpPost]
        public async Task<IActionResult> CreateAdvance(CreateAdvanceCommand command)
        {
            await _createAdvanceCommandhandler.Handle(command);
            return Ok("Avans bilgisi eklendi.");
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveAdvance(int id)
        {
            await _removeAdvanceCommandHandler.Handle(new RemoveAdvanceCommand(id));
            return Ok("Avans bilgisi silindi.");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAdvance(UpdateAdvanceCommand command)
        {
            await _updateAdvanceCommandhandler.Handle(command);
            return Ok("Avans bilgisi güncellendi.");
        }

        #endregion

    }
}