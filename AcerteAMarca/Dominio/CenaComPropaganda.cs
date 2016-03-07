using System;
using System.Collections.Generic;

namespace Dominio
{
    /// <summary>
    /// CenaComPropaganda representa uma cena de um programa de TV que ocorre uma propaganda de um determinado produto ou serviço. Também possui as marcas que serão opção de escolha para o participante telespectador, o produto ou serviço da propaganda e a marca deste.
    /// </summary>
    public class CenaComPropaganda
    {
        #region Properties
        public long ID { get; set; }
        public long ProgramaDeTvID { get; set; }
        public string DescricaoDaCena { get; set; }
        public StatusControlador StatusControlador { get; set; }
        public DateTime? DataAnunciar { get; set; }
        public DateTime? DataAcontecer { get; set; }
        public DateTime? DataFinalizar { get; set; }
        public long ObjetoDePropagandaID { get; set; }
        public long MarcaEfetivamentePublicadaID { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ProgramaDeTV ProgramaDeTv { get; set; }
        public virtual ObjetoDePropaganda ObjetoDePropaganda { get; set; }
        public virtual Marca MarcaEfetivamentePublicada { get; set; }
        public virtual ICollection<Marca> OpcoesDeMarca { get; set; }
        public ICollection<ParticipacaoDoTelespectador> ParticipacoesDeTelespectador { get; set; }
        #endregion
    }
}