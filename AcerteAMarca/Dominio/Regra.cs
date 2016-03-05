using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Regra
    {
        #region Properties
        public long PremiacaoID { get; set; }
        public long ID { get; set; }
        [Display(Name ="Descrições")]
        public string Descricao { get; set; }
        #endregion

        #region Navigatin Properties
        public virtual Premiacao Premiacao { get; set; }
        #endregion

    }
}