using System.Collections.Generic;

namespace Dominio
{
    public class Premiacao
    {
        public long Id { get; set; }
        public string ObjetoPremio { get; set; }
        public List<string> Regras { get; set; }
    }
}