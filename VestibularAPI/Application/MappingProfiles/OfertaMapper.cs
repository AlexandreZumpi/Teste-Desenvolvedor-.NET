using Application.DTOs.Oferta;
using AutoMapper;
using Domain.Entities;

namespace Application.MappingProfiles
{
    public class OfertaMapper : Profile
    {
        public OfertaMapper()
        {
            CreateMap<CreateOfertaDto, Oferta>();
            CreateMap<UpdateOfertaDto, Oferta>();
            CreateMap<Oferta, CreateOfertaDto>();
            CreateMap<Oferta, ReadyOfertaDto>();
        }
    }
}
