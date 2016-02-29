using System.ComponentModel.DataAnnotations;

namespace Dominio
{
    public class Regra
    {
        public long Id { get; set; }

        [Display(Name ="Descrições")]
        public string Descricao { get; set; }
    }
}