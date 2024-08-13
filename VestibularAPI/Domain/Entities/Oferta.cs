using Domain.Base;

namespace Domain.Entities
{
    public class Oferta : BaseEntity
    {
        public string Nome { get; set; }
        public string Descricao { get; set; }
        public int VagasDisponiveis { get; set; }
    }
}
