using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Propaganda é alusiva a uma única cena de programa de TV
    /// </summary>
    public class Propaganda
    {
        public long Id { get; set; }
        public CenaParaPropaganda Cena { get; set; }
        public virtual ICollection<Marca> OpcoesDeMarcasParaProdutoNaCena { get; set; }
    }
}
