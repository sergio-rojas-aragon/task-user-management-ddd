using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using TUM.Application.Common.Interfaces;
using TUM.Application.DTOs;
using TUM.Application.UseCases.EstadoTareaCases;


namespace TUM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosTareaController : ControllerBase
    {
        private CrearEstadoTareaHandler _handler;

        public EstadosTareaController(
            CrearEstadoTareaHandler handler
            )
        {
            _handler = handler;
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CrearEstadoTarea([FromBody] CrearEstadoTareaDTO dto)
        {
            string userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;
            var et = await _handler.Handle(dto, userId);
            return CreatedAtAction(nameof(GetEstadoTareaById), new { id = et }, et);
        }

        [HttpGet("{id:int}")]
        public async Task<IActionResult> GetEstadoTareaById(int id, [FromServices] IEstadoTareaRepository repo)
        {
            var et = await repo.GetByIdAsync(id);
            if (et == null) return NotFound();

            return Ok(et);
        }
   
        [HttpGet]
        public IActionResult GetTareas()
        {
            var userId = User.FindFirst(ClaimTypes.NameIdentifier)?.Value;

            var a = new string[] { "value1", "value2" };
            return Ok(a);
        }
    }
}
