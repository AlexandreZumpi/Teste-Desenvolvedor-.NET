using Application.DTOs.Inscricao;
using Application.DTOs.Lead;
using AutoMapper;
using Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.MappingProfiles
{
    public class InscricaoMapper : Profile
    {
        public InscricaoMapper()
        {
            CreateMap<Inscricao, ReadyInscricaoDto>();
        }
    }
}
