using Application.Services;
using Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InscricoesController : ControllerBase
    {
        private readonly InscricaoService _inscricaoService;

        public InscricoesController(InscricaoService inscricaoService)
        {
            _inscricaoService = inscricaoService;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll() => Ok(await _inscricaoService.GetAllAsync());

        [HttpGet("{id}")]
        public async Task<IActionResult> GetById(int id) => Ok(await _inscricaoService.GetByIdAsync(id));

        [HttpPost]
        public async Task<IActionResult> Create(Inscricao inscricao)
        {
            //if (inscricao == null) return BadRequest();
            await _inscricaoService.AddAsync(inscricao);
            return CreatedAtAction(nameof(GetById), new { id = inscricao.Id }, inscricao);
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, Inscricao inscricao)
        {
            if (id != inscricao.Id) return BadRequest();
            await _inscricaoService.UpdateAsync(inscricao);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await _inscricaoService.DeleteAsync(id);
            return NoContent();
        }

        [HttpGet("cpf/{cpf}")]
        public async Task<IActionResult> GetByCpf(string cpf) => Ok(await _inscricaoService.GetByCpfAsync(cpf));

        [HttpGet("oferta/{ofertaId}/inscricoes")]
        public async Task<IActionResult> GetByOfertaId(int ofertaId) => Ok(await _inscricaoService.GetByOfertaIdAsync(ofertaId));
    }
}
