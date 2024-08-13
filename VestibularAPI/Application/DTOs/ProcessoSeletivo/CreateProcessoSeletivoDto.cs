using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.ProcessoSeletivo
{
    public class CreateProcessoSeletivoDto
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
    }
}
