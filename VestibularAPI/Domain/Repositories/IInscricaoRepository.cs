using Domain.Entities;

namespace Domain.Repositories
{
    public interface IInscricaoRepository : IRepository<Inscricao>
    {
        Task<IEnumerable<Inscricao>> GetInscricoesByCpfAsync(string cpf);
        Task<IEnumerable<Inscricao>> GetInscricoesByOfertaIdAsync(int ofertaId);
    }
}
