using Domain.Entities;

namespace Domain.Repositories
{
    public interface ILeadRepository : IRepository<Lead>
    {
        Task<Lead> AddLeadAsync(Lead lead);
    }
}