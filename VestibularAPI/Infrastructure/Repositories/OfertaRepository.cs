using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class OfertaRepository : Repository<Oferta>, IOfertaRepository
    {
        public OfertaRepository(AppDbContext context) : base(context) { }

        public async Task<Oferta> AddOfertaAsync(Oferta oferta)
        {
            await _context.AddAsync(oferta);
            await _context.SaveChangesAsync();
            return oferta;
        }
    }
}
