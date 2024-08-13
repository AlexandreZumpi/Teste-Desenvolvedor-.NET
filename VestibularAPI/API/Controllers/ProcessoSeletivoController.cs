using Application.DTOs.ProcessoSeletivo;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProcessoSeletivoController : ControllerBase
    {
        private readonly ProcessoSeletivoService _processoSeletivoService;

        public ProcessoSeletivoController(ProcessoSeletivoService processoSeletivoService)
        {
            _processoSeletivoService = processoSeletivoService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> GetAll()
        {
            var oferta = await _processoSeletivoService.GetAllAsync();
            if (oferta == null)
            {
                return NotFound();
            }
            return Ok(oferta);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> GetById(int id)
        {
            var oferta = await _processoSeletivoService.GetByIdAsync(id);
            if (oferta == null)
            {
                return NotFound();
            }
            return Ok(oferta);
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(CreateProcessoSeletivoDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Create([FromBody] CreateProcessoSeletivoDto processoSeletivo)
        {
            if (processoSeletivo == null) return BadRequest();
            var processoSeletivoEntities = await _processoSeletivoService.AddAsync(processoSeletivo);
            return CreatedAtAction(nameof(GetById), new { id = processoSeletivoEntities.Id }, processoSeletivoEntities);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateProcessoSeletivoDto processoSeletivo)
        {
            if (id == 0) return BadRequest();
            await _processoSeletivoService.UpdateAsync(id, processoSeletivo);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0) return BadRequest();
            await _processoSeletivoService.DeleteAsync(id);
            return NoContent();
        }
    }
}