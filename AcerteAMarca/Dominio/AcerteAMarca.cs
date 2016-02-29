using System.Collections.Generic;

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
