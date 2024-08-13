using Application.DTOs.Oferta;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class OfertaService
    {
        private readonly IOfertaRepository _ofertaRepository;
        private readonly IMapper _mapper;

        public OfertaService(IOfertaRepository ofertaRepository, IMapper mapper)
        {
            _ofertaRepository = ofertaRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadyOfertaDto>> GetAllAsync()
        {
            var ofertaEntities = await _ofertaRepository.GetAllAsync();
            var ofertaEntitiesRead = _mapper.Map<IEnumerable<ReadyOfertaDto>>(ofertaEntities);
            return ofertaEntitiesRead;
        }

        public async Task<ReadyOfertaDto> GetByIdAsync(int id)
        {
            var ofertaEntities = await _ofertaRepository.GetByIdAsync(id);
            var ofertaEntitiesRead = _mapper.Map<ReadyOfertaDto>(ofertaEntities);
            return ofertaEntitiesRead;
        }

        public async Task<ReadyOfertaDto> AddAsync(CreateOfertaDto oferta)
        {
            var ofertaEntities = _mapper.Map<Oferta>(oferta);
            await _ofertaRepository.AddOfertaAsync(ofertaEntities);
            var ofertaEntitiesRead = _mapper.Map<ReadyOfertaDto>(ofertaEntities);
            return ofertaEntitiesRead;
        }

        public async Task UpdateAsync(Oferta oferta) => await _ofertaRepository.UpdateAsync(oferta);
        public async Task UpdateAsync(int Id, UpdateOfertaDto oferta)
        {
            var ofertaEntities = _mapper.Map<Oferta>(oferta);
            ofertaEntities.Id = Id;
            await _ofertaRepository.UpdateAsync(ofertaEntities);
        }
        public async Task DeleteAsync(int id) => await _ofertaRepository.DeleteAsync(id);
    }
}
