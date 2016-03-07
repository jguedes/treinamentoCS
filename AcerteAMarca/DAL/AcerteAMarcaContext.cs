using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Dominio;
using System.Data.Entity.ModelConfiguration.Conventions;
namespace DAL
{
    public class AcerteAMarcaContext : DbContext
    {
        public DbSet<AcerteAMarca> AcerteAMarca { get; set; }
        public DbSet<ProgramaDeTV> ProgramaDeTV { get; set; }
        public DbSet<CenaComPropaganda> Cena { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<ObjetoDePropaganda> Produto { get; set; }
        public DbSet<TelespectadorParticipante> TelespactadorParticipante { get; set; }
        public DbSet<ParticipacaoDoTelespectador> ParticipacaoDoTelespectador { get; set; }
        public DbSet<Premiacao> Premiacao { get; set; }
        public DbSet<Regra> Regras { get; set; }

        public AcerteAMarcaContext() : base("AcerteamarcaDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBiulder)
        {
            modelBiulder.Conventions.Remove<PluralizingTableNameConvention>();

            //modelBiulder.Entity<Marca>()
            //    .HasMany<ObjetoDePropaganda>(m => m.ObjetosDePropaganda);
            //modelBiulder.Entity<ObjetoDePropaganda>()
            //    .HasMany<Marca>(p => p.Marcas);
            //modelBiulder.Entity<CenaParaPropaganda>()
            //    .HasRequired<ObjetoDePropaganda>(r => r.Produto);
            //modelBiulder.Entity<Propaganda>()
            //    .HasMany<Marca>(p => p.OpcoesDeMarcasParaProdutoNaCena);
            //modelBiulder.Entity<ProgramaDeTV>()
            //    .HasMany<Propaganda>(p => p.CenasComPropaganda);
            //modelBiulder.Entity<Premiacao>()
            //    .HasMany<Regra>(p => p.Regras);
            //modelBiulder.Entity<PropagandaMarcada>()
            //    .HasRequired<Propaganda>(r => r.PropagandaVisualizada);
            //modelBiulder.Entity<TelespectadorParticipante>()
            //    .HasMany<PropagandaMarcada>(t => t.PropagandasMarcadas);
            //modelBiulder.Entity<AcerteAMarca>()
            //    .HasMany<ProgramaDeTV>(a => a.ProgramasDeTV);
            //modelBiulder.Entity<AcerteAMarca>()
            //    .HasMany<TelespectadorParticipante>(a => a.TelespectadoresParticipantes);
            //modelBiulder.Entity<AcerteAMarca>()
            //    .HasMany<Premiacao>(a => a.Premiacoes);
        }

    }
}