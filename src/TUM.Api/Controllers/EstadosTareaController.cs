using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TUM.Application.Common.Interfaces;
using TUM.Application.DTOs;
using TUM.Application.UseCases;


namespace TUM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosTareaController : ControllerBase
    {
        private CrearEstadoTareaHandler _handler;

        public EstadosTareaController(CrearEstadoTareaHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        public async Task<IActionResult> CrearEstadoTarea([FromBody] CrearEstadoTareaDTO dto)
        {
            var et = await _handler.Handle(dto);
            return CreatedAtAction(nameof(GetEstadoTareaById), new { id = et }, et);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEstadoTareaById(int id, [FromServices] IEstadoTareaRepository repo)
        {
            var et = await repo.GetByIdAsync(id);
            if (et == null) return NotFound();

            return Ok(et);
        }
    }
}
