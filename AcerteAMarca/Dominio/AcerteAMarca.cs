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
        public virtual ICollection<ProgramaDeTV> ProgramasDeTV
        {
            get {
                if (ProgramasDeTV.Equals(null))
                {
                    return new List<ProgramaDeTV>();
                }
                else
                {
                    return ProgramasDeTV;
                }
            }
            set
            {
                ProgramasDeTV = value;
            }
        }
        public virtual ICollection<TelespectadorParticipante> TelespectadoresParticipantes
        {
            get
            {
                if (TelespectadoresParticipantes.Equals(null))
                {
                    return new List<TelespectadorParticipante>();
                }
                else
                {
                    return TelespectadoresParticipantes;
                }
            }
            set
            {
                TelespectadoresParticipantes = value;
            }
        }
        public virtual ICollection<Premiacao> Premiacoes
        {
            get
            {
                if (Premiacoes.Equals(null))
                {
                    return new List<Premiacao>();
                }
                else
                {
                    return Premiacoes;
                }
            }
                set
            {
                Premiacoes = value;
            }
        }
        #endregion

    }
}
