using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// ProgramaDeTv possui um conjunto de propagandas que são realizadas em suas cenas.
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
        public virtual ICollection<Propaganda> Propagandas
        {
            get
            {
                if (Propagandas.Equals("null"))
                {
                    return new List<Propaganda>();
                }
                else
                {
                    return Propagandas;
                }
            }
            set
            {
                Propagandas = value;
            }
        }
        #endregion
    }
}
