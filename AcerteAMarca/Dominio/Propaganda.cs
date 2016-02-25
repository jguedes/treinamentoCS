using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class Propaganda
    {
        public long Id { get; set; }
        public CenaParaPropaganda Cena { get; set; }
        public List<Marca> OpcoesDeMarcasParaProdutoNaCena { get; set; }
    }
}
