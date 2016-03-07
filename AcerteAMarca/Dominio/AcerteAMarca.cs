using System.Collections.Generic;

namespace Dominio
{
    /// <summary>
    /// AcerteAMArca é a classe principal:
    /// Possui um conjunto de programas de TV que têm propagandas para a promoção;
    /// Possui um conjunto de Telespectadores participantes, e;
    /// Possui um conjunto de prêmios para a promoção.
    /// </summary>
    public class AcerteAMarca
    {

        #region Properties
        public long ID { get; set; }
        #endregion

        #region Properties
        public virtual ICollection<ProgramaDeTV> ProgramasDeTV { get; set; }
        public virtual ICollection<TelespectadorParticipante> TelespectadoresParticipantes { get; set; }
        public virtual ICollection<Premiacao> Premiacoes { get; set; }
        #endregion

    }
}
