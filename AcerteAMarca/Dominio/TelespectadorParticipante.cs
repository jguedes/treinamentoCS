﻿using System.Collections.Generic;

namespace Dominio
{
    public class TelespectadorParticipante
    {
        #region Properties
        public long ID { get; set; }
        //public long AcerteAMarcaID { get; set; }
        public string IdentificadorDoTelespectador { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<ParticipacaoDoTelespectador> ParticipacoesDoTelespectador { get; set; }
        public virtual ICollection<AcerteAMarca> OsAcerteAMarcaQueEsteTelespcParticipa { get; set; }
        public virtual ICollection<Premiacao> PremiacoesGanhadas { get; set; }
        #endregion
    }
}