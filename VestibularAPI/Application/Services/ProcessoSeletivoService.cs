using Application.DTOs.Oferta;
using Application.DTOs.ProcessoSeletivo;
using AutoMapper;
using Domain.Entities;
using Domain.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services
{
    public class ProcessoSeletivoService
    {
        private readonly IProcessoSeletivoRepository _processoSeletivoRepository;
        private readonly IMapper _mapper;

        public ProcessoSeletivoService(IProcessoSeletivoRepository processoSeletivoRepository, IMapper mapper)
        {
            _processoSeletivoRepository = processoSeletivoRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<ReadyProcessoSeletivoDto>> GetAllAsync()
        {
            var processoSeletivoEntities = await _processoSeletivoRepository.GetAllAsync();
            var processoSeletivoRead = _mapper.Map<IEnumerable<ReadyProcessoSeletivoDto>>(processoSeletivoEntities);
            return processoSeletivoRead;
        }

        public async Task<ReadyProcessoSeletivoDto> GetByIdAsync(int id)
        {
            var processoSeletivoEntities = await _processoSeletivoRepository.GetByIdAsync(id);
            var processoSeletivoRead = _mapper.Map<ReadyProcessoSeletivoDto>(processoSeletivoEntities);
            return processoSeletivoRead;
        }

        public async Task<ReadyProcessoSeletivoDto> AddAsync(CreateProcessoSeletivoDto processoSeletivo)
        {
            var ProcessoSeletivoEntities = _mapper.Map<ProcessoSeletivo>(processoSeletivo);
            await _processoSeletivoRepository.AddProcessoSeletivoAsync(ProcessoSeletivoEntities);
            var processoSeletivoRead = _mapper.Map<ReadyProcessoSeletivoDto>(ProcessoSeletivoEntities);
            return processoSeletivoRead;
        }

        public async Task UpdateAsync(int Id, UpdateProcessoSeletivoDto processoSeletivo)
        {
            var processoSeletivoEntities = _mapper.Map<ProcessoSeletivo>(processoSeletivo);
            processoSeletivoEntities.Id = Id;
            await _processoSeletivoRepository.UpdateAsync(processoSeletivoEntities);
        }

        public async Task DeleteAsync(int id) => await _processoSeletivoRepository.DeleteAsync(id);

    }
}
