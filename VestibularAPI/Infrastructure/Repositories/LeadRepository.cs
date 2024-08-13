using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class LeadRepository : Repository<Lead>, ILeadRepository
    {
        public LeadRepository(AppDbContext context) : base(context) { }

        public async Task<Lead> AddLeadAsync(Lead lead)
        {
            await _context.AddAsync(lead);
            await _context.SaveChangesAsync();
            return lead;
        }
    }
}
