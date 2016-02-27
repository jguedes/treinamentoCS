namespace Dominio
{
    public class PropagandaMarcada
    {
        public long Id { get; set; }
        public virtual Propaganda PropagandaVisualizada { get; set; }
        public Marca MarcaEscolhida { get; set; }
        public Marca MarcaQueApareceu { get; set; }
        public bool efetivada { get; set; }
    }
}