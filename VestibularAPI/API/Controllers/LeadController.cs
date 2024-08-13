using Application.DTOs.Lead;
using Application.DTOs.ProcessoSeletivo;
using Application.Services;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LeadController : ControllerBase
    {
        private readonly LeadService _leadService;

        public LeadController(LeadService leadService)
        {
            _leadService = leadService;
        }

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> GetAll()
        {
            var lead = await _leadService.GetAllAsync();
            if (lead == null)
            {
                return NotFound();
            }
            return Ok(lead);
        }

        [HttpGet("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> GetById(int id)
        {
            var lead = await _leadService.GetByIdAsync(id);
            if (lead == null)
            {
                return NotFound();
            }
            return Ok(lead);
        }

        [HttpPost]
        [ProducesResponseType((200), Type = typeof(CreateLeadDto))]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Create([FromBody] CreateLeadDto lead)
        {
            if (lead == null) return BadRequest();
            var leadEntities = await _leadService.AddAsync(lead);
            return CreatedAtAction(nameof(GetById), new { id = leadEntities.Id }, leadEntities);
        }

        [HttpPut("{id}")]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Update(int id, [FromBody] UpdateLeadDto lead)
        {
            if (id == 0) return BadRequest();
            await _leadService.UpdateAsync(id, lead);
            return NoContent();
        }

        [HttpDelete("{id}")]
        [ProducesResponseType(204)]
        [ProducesResponseType(400)]
        [ProducesResponseType(401)]
        public async Task<IActionResult> Delete(int id)
        {
            if (id == 0) return BadRequest();
            await _leadService.DeleteAsync(id);
            return NoContent();
        }
    }
}
