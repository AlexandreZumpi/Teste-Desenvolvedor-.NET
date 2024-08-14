using Application.DTOs.Lead;
using Application.DTOs.Oferta;
using Application.DTOs.ProcessoSeletivo;

namespace Application.DTOs.Inscricao
{
    public class ReadyInscricaoDto
    {
        public int Id { get; set; }
        public string NumeroInscricao { get; set; }
        public DateTime Data { get; set; }
        public string Status { get; set; }
        public ReadyLeadDto Lead { get; set; }
        public ReadyProcessoSeletivoDto ProcessoSeletivo { get; set; }
        public ReadyOfertaDto Oferta { get; set; }
    }
}
