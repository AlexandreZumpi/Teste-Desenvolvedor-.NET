using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class InscricaoService
    {
        private readonly IInscricaoRepository _inscricaoRepository;

        public InscricaoService(IInscricaoRepository inscricaoRepository)
        {
            _inscricaoRepository = inscricaoRepository;
        }

        public async Task<IEnumerable<Inscricao>> GetAllAsync() => await _inscricaoRepository.GetAllAsync();

        public async Task<Inscricao> GetByIdAsync(int id) => await _inscricaoRepository.GetByIdAsync(id);

        public async Task AddAsync(Inscricao inscricao) => await _inscricaoRepository.AddAsync(inscricao);

        public async Task UpdateAsync(Inscricao inscricao) => await _inscricaoRepository.UpdateAsync(inscricao);

        public async Task DeleteAsync(int id) => await _inscricaoRepository.DeleteAsync(id);

        public async Task<IEnumerable<Inscricao>> GetByCpfAsync(string cpf) => await _inscricaoRepository.GetInscricoesByCpfAsync(cpf);

        public async Task<IEnumerable<Inscricao>> GetByOfertaIdAsync(int ofertaId) => await _inscricaoRepository.GetInscricoesByOfertaIdAsync(ofertaId);
    }
}
