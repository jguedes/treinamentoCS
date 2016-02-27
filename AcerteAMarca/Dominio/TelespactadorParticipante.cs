using System.Collections.Generic;

namespace Dominio
{
    public class TelespactadorParticipante
    {
        public long Id { get; set; }
        public string IdentificadorDoTelespectador { get; set; }
        public virtual ICollection<PropagandaMarcada> PropagandasMarcadas { get; set; }
    }
}