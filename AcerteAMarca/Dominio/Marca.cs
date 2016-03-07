using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
    /// <summary>
    /// Marca representa uma organização que participa da promoção através da compra de divulgação de sua marca e com a publicidade de seus produtos ou serviços.
    /// </summary>
    public class Marca
    {
        #region Properties
        public long ID { get; set; }
        public string Nome { get; set; }
        #endregion

        #region Navigation Properties
        public virtual ICollection<ObjetoDePropaganda> ObjetosDePropaganda
        {
            get
            {
                if (ObjetosDePropaganda.Equals("null"))
                {
                    return new List<ObjetoDePropaganda>();
                }
                else
                {
                    return ObjetosDePropaganda;
                }
            }
            set
            {
                ObjetosDePropaganda = value;
            }
        }
        public virtual ICollection<ParticipacaoDoTelespectador> ParticipacoesDeTelespectadoresQueEscolheramEstaMarca
        {
            get
            {
                if (ParticipacoesDeTelespectadoresQueEscolheramEstaMarca.Equals("null"))
                {
                    return new List<ParticipacaoDoTelespectador>();
                }
                else
                {
                    return ParticipacoesDeTelespectadoresQueEscolheramEstaMarca;
                }
            }
            set
            {
                ParticipacoesDeTelespectadoresQueEscolheramEstaMarca = value;
            }
        }
        public virtual ICollection<ParticipacaoDoTelespectador> ParticipacoesDeTelespectadoresQueMarcaramEstaMarcaComoPublicada
        {
            get
            {
                if (ParticipacoesDeTelespectadoresQueMarcaramEstaMarcaComoPublicada.Equals("null"))
                {
                    return new List<ParticipacaoDoTelespectador>();
                }
                else
                {
                    return ParticipacoesDeTelespectadoresQueMarcaramEstaMarcaComoPublicada;
                }
            }
            set
            {
                ParticipacoesDeTelespectadoresQueEscolheramEstaMarca = value;
            }
        }
        public virtual ICollection<CenaComPropaganda> CenasComPropagandaComEstaMarca
        {
            get
            {
                if (CenasComPropagandaComEstaMarca.Equals("null"))
                {
                    return new List<CenaComPropaganda>();
                }
                else
                {
                    return CenasComPropagandaComEstaMarca;
                }
            }
            set
            {
                CenasComPropagandaComEstaMarca = value;
            }
        }
        public virtual ICollection<CenaComPropaganda> ParticipacoesDestaMarcaComoOpcao
        {
            get
            {
                if (ParticipacoesDestaMarcaComoOpcao.Equals("null"))
                {
                    return new List<CenaComPropaganda>();
                }
                else
                {
                    return ParticipacoesDestaMarcaComoOpcao;
                }
            }
            set
            {
                ParticipacoesDestaMarcaComoOpcao = value;
            }
        }
        #endregion
    }
}
