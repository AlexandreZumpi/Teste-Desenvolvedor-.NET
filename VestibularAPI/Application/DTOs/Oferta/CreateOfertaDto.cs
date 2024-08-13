using System.ComponentModel.DataAnnotations;

namespace Application.DTOs.Oferta
{
    public class CreateOfertaDto
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int VagasDisponiveis { get; set; }
    }
}
