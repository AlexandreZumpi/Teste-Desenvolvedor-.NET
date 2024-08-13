using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace Infrastructure.Repositories
{
    public class InscricaoRepository : Repository<Inscricao>, IInscricaoRepository
    {
        public InscricaoRepository(AppDbContext context) : base(context) { }

        public async Task<IEnumerable<Inscricao>> GetInscricoesByCpfAsync(string cpf)
        {
            return await _context.Inscricoes
                .Include(i => i.Lead)
                .Where(i => i.Lead.CPF == cpf)
                .ToListAsync();
        }

        public async Task<IEnumerable<Inscricao>> GetInscricoesByOfertaIdAsync(int ofertaId)
        {
            return await _context.Inscricoes
                .Include(i => i.Oferta)
                .Where(i => i.OfertaId == ofertaId)
                .ToListAsync();
        }
    }
}
