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

            modelBiulder.Entity<Regra>()
                .HasKey(r => r.ID);
            modelBiulder.Entity<Regra>()
                .HasRequired<Premiacao>(r => r.Premiacao)
                .WithMany(p => p.Regras)
                .HasForeignKey(r => r.PremiacaoID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<Premiacao>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<Premiacao>()
                .HasRequired<AcerteAMarca>(p=>p.AcerteAMarca)
                .WithMany(a=>a.Premiacoes)
                .HasForeignKey(p=>p.AcerteAMarcaID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<Premiacao>()
                .HasMany<TelespectadorParticipante>(p => p.Vencedores)
                .WithMany(a => a.PremiacoesGanhadas)
                .Map(t => t.ToTable("PreminacoesEGanhadores"));
            modelBiulder.Entity<TelespectadorParticipante>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<TelespectadorParticipante>()
                .HasRequired<AcerteAMarca>(t => t.AcerteAMarca)
                .WithMany(a => a.TelespectadoresParticipantes)
                .HasForeignKey(p => p.AcerteAMarcaID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<TelespectadorParticipante>()
                .HasMany<ParticipacaoDoTelespectador>(t => t.ParticipacoesDoTelespectador)
                .WithRequired(p => p.TelespectadorParticipante)
                .HasForeignKey(p => p.TelespectadorParticipanteID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasRequired<CenaComPropaganda>(p=>p.CenaComPropaganda)
                .WithMany(c=>c.ParticipacoesDeTelespectador)
                .HasForeignKey(p=>p.CenaComPropagandaID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasOptional<Marca>(p=>p.MarcaEscolhida)
                .WithMany(m=>m.ParticipacoesDeTelespectadoresQueEscolheramEstaMarca)
                .HasForeignKey(p=>p.MarcaEscolhidaID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasOptional<Marca>(p => p.MarcaPublicada)
                .WithMany(m => m.ParticipacoesDeTelespectadoresQueMarcaramEstaMarcaComoPublicada)
                .HasForeignKey(p => p.MarcaPublicadaID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasRequired<ProgramaDeTV>(c=>c.ProgramaDeTv)
                .WithMany(p=>p.CenasComPropaganda)
                .HasForeignKey(c=>c.ProgramaDeTvID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasRequired<ObjetoDePropaganda>(c => c.ObjetoDePropaganda)
                .WithMany(o => o.CenasComPropagandaDesteObjeto)
                .HasForeignKey(c => c.ObjetoDePropagandaID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasOptional<Marca>(c => c.MarcaEfetivamentePublicada)
                .WithMany(o => o.CenasComPropagandaComEstaMarca)
                .HasForeignKey(c => c.MarcaEfetivamentePublicadaID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasMany<Marca>(c => c.OpcoesDeMarca)
                .WithMany(m => m.ParticipacoesDestaMarcaComoOpcao)
                .Map(t => t.ToTable("CenaComPropaganda_MarcaDeOpcao"));
            modelBiulder.Entity<ObjetoDePropaganda>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<ObjetoDePropaganda>()
                .HasMany<Marca>(o => o.Marcas)
                .WithMany(m => m.ObjetosDePropaganda)
                .Map(t => t.ToTable("Marca_ObjetoDePropaganda"));
            modelBiulder.Entity<ProgramaDeTV>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<ProgramaDeTV>()
                .HasRequired<AcerteAMarca>(p => p.AcerteAMarca)
                .WithMany(a => a.ProgramasDeTV)
                .HasForeignKey(p => p.AcerteAMarcaID)
                .WillCascadeOnDelete(false);
        }

    }
}