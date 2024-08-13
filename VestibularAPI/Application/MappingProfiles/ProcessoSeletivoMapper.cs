using Application.DTOs.Oferta;
using Application.DTOs.ProcessoSeletivo;
using AutoMapper;
using Domain.Entities;

namespace Application.MappingProfiles
{
    public class ProcessoSeletivoMapper : Profile
    {
        public ProcessoSeletivoMapper()
        {
            CreateMap<CreateProcessoSeletivoDto, ProcessoSeletivo>();
            CreateMap<UpdateProcessoSeletivoDto, ProcessoSeletivo>();
            CreateMap<ProcessoSeletivo, CreateProcessoSeletivoDto>();
            CreateMap<ProcessoSeletivo, ReadyProcessoSeletivoDto>();
        }
    }
}
