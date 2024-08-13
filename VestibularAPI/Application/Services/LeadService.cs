using Application.DTOs.Lead;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;

namespace Application.Services
{
    public class LeadService
    {
        private readonly ILeadRepository _leadRepository;
        private readonly IMapper _mapper;

        public LeadService(ILeadRepository leadRepository, IMapper mapper)
        {
            _leadRepository = leadRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadyLeadDto>> GetAllAsync()
        {
            var LeadEntities = await _leadRepository.GetAllAsync();
            var leadRead = _mapper.Map<IEnumerable<ReadyLeadDto>>(LeadEntities);
            return leadRead;
        }

        public async Task<ReadyLeadDto> GetByIdAsync(int id)
        {
            var LeadEntities = await _leadRepository.GetByIdAsync(id);
            var LeadRead = _mapper.Map<ReadyLeadDto>(LeadEntities);
            return LeadRead;
        }

        public async Task<ReadyLeadDto> AddAsync(CreateLeadDto lead)
        {
            var LeadEntities = _mapper.Map<Lead>(lead);
            await _leadRepository.AddLeadAsync(LeadEntities);
            var leadRead = _mapper.Map<ReadyLeadDto>(LeadEntities);
            return leadRead;
        }

        public async Task UpdateAsync(int Id, UpdateLeadDto lead)
        {
            var leadEntities = _mapper.Map<Lead>(lead);
            leadEntities.Id = Id;
            await _leadRepository.UpdateAsync(leadEntities);
        }

        public async Task DeleteAsync(int id) => await _leadRepository.DeleteAsync(id);

    }
}
