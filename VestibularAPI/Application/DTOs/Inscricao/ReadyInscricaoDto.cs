using Application.DTOs.Lead;
using Application.DTOs.Oferta;
using Application.DTOs.ProcessoSeletivo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Inscricao
{
    public class ReadyInscricaoDto
    {
        public int Id { get; set; }
        public string NumeroInscricao { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }

        //public int LeadId { get; set; }

        public ReadyLeadDto Lead { get; set; }

        //public int ProcessoSeletivoId { get; set; }

        public ReadyProcessoSeletivoDto ProcessoSeletivo { get; set; }

        //public int OfertaId { get; set; }
        public ReadyOfertaDto Oferta { get; set; }
    }
}
