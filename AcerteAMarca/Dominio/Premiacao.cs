using System.Collections.Generic;

namespace Dominio
{
    public class Premiacao
    {
        public long Id { get; set; }
        public string ObjetoPremio { get; set; }
        public virtual ICollection<Regra> Regras { get; set; }
    }
}