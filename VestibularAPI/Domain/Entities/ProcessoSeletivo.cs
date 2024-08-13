using Domain.Base;

namespace Domain.Entities
{
    public class ProcessoSeletivo : BaseEntity
    {
        public string Nome { get; set; }
        public DateTime DataInicio { get; set; }
        public DateTime DataTermino { get; set; }
    }
}
