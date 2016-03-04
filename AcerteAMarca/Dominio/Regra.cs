using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Regra
    {
        public long Id { get; set; }

        [Display(Name ="Descrições")]
        public string Descricao { get; set; }
        
        public long Premiacao_Id { get; set; }

    }
}