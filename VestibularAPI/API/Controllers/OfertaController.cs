using Application.DTOs.Oferta;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OfertaController : ControllerBase
    {
        private readonly OfertaService _ofertaService;

        public OfertaController(OfertaService ofertaService)
        {
            _ofertaService = ofertaService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> GetAll()
        {
            var oferta = await _ofertaService.GetAllAsync();
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
            var oferta = await _ofertaService.GetByIdAsync(id);
            if (oferta == null)
            {
                return NotFound();
            }
            return Ok(oferta);
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(CreateOfertaDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Create([FromBody] CreateOfertaDto oferta)
        {
            if (oferta == null) return BadRequest();
            var ofertaEntities = await _ofertaService.AddAsync(oferta);
            return CreatedAtAction(nameof(GetById), new { id = ofertaEntities.Id }, ofertaEntities);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateOfertaDto oferta)
        {
            if (id == 0) return BadRequest();
            await _ofertaService.UpdateAsync(id, oferta);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0) return BadRequest();
            await _ofertaService.DeleteAsync(id);
            return NoContent();
        }
    }
}
