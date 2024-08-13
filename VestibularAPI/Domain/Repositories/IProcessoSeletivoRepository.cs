using Domain.Entities;

namespace Domain.Repositories
{
    public interface IProcessoSeletivoRepository : IRepository<ProcessoSeletivo>
    {
        Task<ProcessoSeletivo> AddProcessoSeletivoAsync(ProcessoSeletivo processoSeletivo);
    }
}