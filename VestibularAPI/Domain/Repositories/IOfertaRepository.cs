using Domain.Entities;

namespace Domain.Repositories
{
    public interface IOfertaRepository : IRepository<Oferta>
    {
        Task<Oferta> AddOfertaAsync(Oferta oferta);
    }
}
