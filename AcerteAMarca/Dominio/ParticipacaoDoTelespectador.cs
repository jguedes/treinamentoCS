namespace Dominio
{
    public class ParticipacaoDoTelespectador
    {
        #region Properties
        public long TelespectadorParticipanteID { get; set; }
        public long CenaComPropagandaID { get; set; }
        public long ID { get; set; }
        public long MarcaEscolhidaID { get; set; }
        public long MarcaPublicadaID { get; set; }
        #endregion

        #region Navigation Properties
        public virtual TelespectadorParticipante TelespectadorParticipante { get; set; }
        public virtual CenaComPropaganda CenaComPropaganda { get; set; }
        public virtual Marca MarcaEscolhida { get; set; }
        public virtual Marca MarcaPublicada { get; set; }
        #endregion
    }
}