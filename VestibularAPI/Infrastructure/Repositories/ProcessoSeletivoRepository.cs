using Domain.Entities;
using Domain.Repositories;
using Infrastructure.Data;

namespace Infrastructure.Repositories
{
    public class ProcessoSeletivoRepository : Repository<ProcessoSeletivo>, IProcessoSeletivoRepository
    {
        public ProcessoSeletivoRepository(AppDbContext context) : base(context) { }

        public async Task<ProcessoSeletivo> AddProcessoSeletivoAsync(ProcessoSeletivo processoSeletivo)
        {
            await _context.AddAsync(processoSeletivo);
            await _context.SaveChangesAsync();
            return processoSeletivo;
        }
    }
}
