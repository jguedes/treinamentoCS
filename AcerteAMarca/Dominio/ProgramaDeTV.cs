using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    public class ProgramaDeTV
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public ICollection<Propaganda> Propagandas { get; set; }
    }
}
