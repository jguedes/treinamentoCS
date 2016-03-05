using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Marca representa uma organização que participa da promoção através da compra de divulgação de sua marca e com a publicidade de seus produtos ou serviços.
    /// </summary>
    public class Marca
    {
        #region Properties
        public long ID { get; set; }
        public string Nome { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<ObjetoDePropaganda> ObjetosDePropaganda
        {
            get
            {
                if (ObjetosDePropaganda.Equals("null"))
                {
                    return new List<ObjetoDePropaganda>();
                }
                else
                {
                    return ObjetosDePropaganda;
                }
            }
            set
            {
                ObjetosDePropaganda = value;
            }
        }
        public virtual ICollection<Marca> Marcas
        {
            get
            {
                if (Marcas.Equals("null"))
                {
                    return new List<Marca>();
                }
                else
                {
                    return Marcas;
                }
            }
            set
            {
                Marcas = value;
            }
        }
        #endregion
    }
}
