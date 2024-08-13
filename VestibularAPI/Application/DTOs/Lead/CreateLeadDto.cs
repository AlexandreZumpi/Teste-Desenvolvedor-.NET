using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.DTOs.Lead
{
    public class CreateLeadDto
    {
        [Required]
        [StringLength(100, MinimumLength = 5)]
        public string Nome { get; set; }

        [Required]
        [StringLength(100)]
        public string Email { get; set; }

        [Required]
        public string Telefone { get; set; }

        [Required]
        public string CPF { get; set; }
    }
}
