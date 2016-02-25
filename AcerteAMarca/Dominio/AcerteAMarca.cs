using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class AcerteAMarca
    {
        public long Id { get; set; }
        public List<ProgramaDeTV> ProgramasDeTV { get; set; }
        public List<TelespactadorParticipante> TelespectadoresParticipantes { get; set; }
        public List<Premiacao> Premiacoes { get; set; }
    }
}
