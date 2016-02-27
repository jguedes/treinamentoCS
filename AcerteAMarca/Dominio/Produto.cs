using System.Collections.Generic;
namespace Dominio
{
    public class Produto
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public virtual ICollection<Marca> Marcas { get; set; }
        public Produto()
        {
            Marcas = new List<Marca>();
        }
    }
}