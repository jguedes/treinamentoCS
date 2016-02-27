using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class AcerteAMarca
    {
        public long Id { get; set; }
        public virtual ICollection<ProgramaDeTV> ProgramasDeTV { get; set; }
        public virtual ICollection<TelespactadorParticipante> TelespectadoresParticipantes { get; set; }
        public virtual ICollection<Premiacao> Premiacoes { get; set; }
    }
}
