using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// ProgramaDeTv possui um conjunto de cenas com propagandas para a promoção.
    /// </summary>
    public class ProgramaDeTV
    {
        #region Properties
        public long acerteAMarcaID { get; set; }
        public long Id { get; set; }
        public string Nome { get; set; }
        #endregion

        #region Navigation properties
        public virtual AcerteAMarca AcerteAMarca { get; set; }
        public virtual ICollection<CenaComPropaganda> CenasComPropaganda
        {
            get
            {
                if (CenasComPropaganda.Equals("null"))
                {
                    return new List<Propaganda>();
                }
                else
                {
                    return CenasComPropaganda;
                }
            }
            set
            {
                CenasComPropaganda = value;
            }
        }
        #endregion
    }
}
