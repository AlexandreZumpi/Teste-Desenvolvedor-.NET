using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Oferta
{
    public class UpdateOfertaDto
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Nome { get; set; }

        [StringLength(100)]
        public string Descricao { get; set; }

        public int VagasDisponiveis { get; set; }
    }
}
