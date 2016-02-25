using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    class CenaParaPropaganda
    {
        public long Id { get; set; }
        public string Identificador { get; set; }
        public Produto Produto { get; set; }
        public DateTime HoraLimiteDeInteracaoComTelespectador { get; set; }
    }
}
