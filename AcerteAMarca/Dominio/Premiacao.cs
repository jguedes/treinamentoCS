using System.Collections.Generic;

namespace Dominio
{
    public class Premiacao
    {
        #region Properties
        public long ID { get; set; }
        public long AcerteAMarcaID { get; set; }
        public string ObjetoPremio { get; set; }
        public int QuantVencendoresPermitido { get; set; }
        #endregion

        #region Navigation Properties   
        public virtual AcerteAMarca AcerteAMarca { get; set; }
        public virtual ICollection<Regra> Regras { get; set; }
        public virtual ICollection<TelespectadorParticipante> Vencedores { get; set; }
        #endregion
    }
}