using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio
{
    public class Regra
    {
        #region Properties
        public long ID { get; set; }
        public long PremiacaoID { get; set; }
        public string Descricao { get; set; }
        #endregion

        #region Navigation Properties
        public virtual Premiacao Premiacao { get; set; }
        #endregion

    }
}