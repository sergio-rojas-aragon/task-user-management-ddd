using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;
using System.Threading.Tasks;
using TUM.Application.Common.Interfaces;
using TUM.Application.DTOs;
using TUM.Application.UseCases.ClientCases;
using TUM.Application.UseCases.EstadoTareaCases;


namespace TUM.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TaskStatusController : ControllerBase
    {
        private CrearEstadoTareaHandler _handler;
        private ListTaskStatusesHandler _list;

        public TaskStatusController(
            CrearEstadoTareaHandler handler, ListTaskStatusesHandler listHandler
            )
        {
            _handler = handler;
            _list = listHandler;
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
        public async Task<IActionResult> Get()
        {
            var result = await _list.Handle();
            return Ok(result);
        }
    }
}
