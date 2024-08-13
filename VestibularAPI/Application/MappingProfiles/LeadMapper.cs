using Application.DTOs.Lead;
using AutoMapper;
using Domain.Entities;

namespace Application.MappingProfiles
{
    public class LeadMapper : Profile
    {
        public LeadMapper()
        {
            CreateMap<CreateLeadDto, Lead>();
            CreateMap<UpdateLeadDto, Lead>();
            CreateMap<Lead, CreateLeadDto>();
            CreateMap<Lead, ReadyLeadDto>();
        }
    }
}
