using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class Propaganda
    {
        public long Id { get; set; }
        public CenaParaPropaganda Cena { get; set; }
        public virtual ICollection<Marca> OpcoesDeMarcasParaProdutoNaCena { get; set; }
    }
}
