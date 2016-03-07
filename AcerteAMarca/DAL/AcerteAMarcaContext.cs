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
        public DbSet<CenaComPropaganda> CenaComPropaganda { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<ObjetoDePropaganda> ObjetoDePropaganda { get; set; }
        public DbSet<TelespectadorParticipante> TelespactadorParticipante { get; set; }
        public DbSet<ParticipacaoDoTelespectador> ParticipacaoDoTelespectador { get; set; }
        public DbSet<Premiacao> Premiacao { get; set; }
        public DbSet<Regra> Regras { get; set; }
        
        protected override void OnModelCreating(DbModelBuilder modelBiulder)
        {
            modelBiulder.Conventions.Remove<PluralizingTableNameConvention>();

            modelBiulder.Entity<AcerteAMarca>()
                .HasKey(r => r.ID);
            modelBiulder.Entity<ProgramaDeTV>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<ObjetoDePropaganda>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<Marca>()
                .HasKey(r => r.ID);
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<TelespectadorParticipante>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<Premiacao>()
                .HasKey(p => p.ID);
            modelBiulder.Entity<Regra>()
                .HasKey(r => r.ID);
            
            modelBiulder.Entity<AcerteAMarca>()
                .HasMany<ProgramaDeTV>(a => a.ProgramasDeTV)
                .WithMany(p => p.ProjetosAcerteAMarcaEmQueEsteProgramaDeTVFazParte)
                .Map(t => t.ToTable("AcerteAMarca_ProgramaDeTV"));
            modelBiulder.Entity<ProgramaDeTV>()
                .HasMany<CenaComPropaganda>(p => p.CenasComPropaganda)
                .WithRequired(c => c.ProgramaDeTv)
                .HasForeignKey(c => c.ProgramaDeTvID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasRequired<ObjetoDePropaganda>(c => c.ObjetoDePropaganda)
                .WithMany(o => o.CenasComPropagandaDesteObjeto)
                .HasForeignKey(c => c.ObjetoDePropagandaID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<ObjetoDePropaganda>()
                .HasMany<Marca>(o => o.MarcasQueVendemEsteObjetoDePropaganda)
                .WithMany(m => m.ObjetosDePropagandaVendidosPorEstaMarca)
                .Map(t => t.ToTable("Marca_ObjetoDePropaganda"));
            modelBiulder.Entity<CenaComPropaganda>()
                .HasOptional<Marca>(c => c.MarcaEfetivamentePublicada)
                .WithMany(m => m.CenasComPropagandaEfetivamenteComEstaMarca)
                .HasForeignKey(c => c.MarcaEfetivamentePublicadaID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<CenaComPropaganda>()
                .HasMany<Marca>(c => c.OpcoesDeMarca)
                .WithMany(m => m.ParticipacoesDestaMarcaComoOpcao)
                .Map(t => t.ToTable("CenaComPropaganda_OpcoesDemarca"));
            modelBiulder.Entity<CenaComPropaganda>()
                .HasMany<ParticipacaoDoTelespectador>(c => c.ParticipacoesDeTelespectador)
                .WithRequired(p => p.CenaComPropaganda)
                .HasForeignKey(p => p.CenaComPropagandaID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasRequired<TelespectadorParticipante>(p => p.TelespectadorParticipante)
                .WithMany(t => t.ParticipacoesDoTelespectador)
                .HasForeignKey(p => p.TelespectadorParticipanteID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<TelespectadorParticipante>()
                .HasMany<AcerteAMarca>(t => t.OsAcerteAMarcaQueEsteTelespcParticipa)
                .WithMany(a => a.TelespectadoresParticipantes)
                .Map(t => t.ToTable("AcerteAMarca_TelespectadorParticipante"));
            modelBiulder.Entity<AcerteAMarca>()
                .HasMany<Premiacao>(a => a.Premiacoes)
                .WithRequired(p => p.AcerteAMarca)
                .HasForeignKey(p => p.AcerteAMarcaID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<Premiacao>()
                .HasMany<Regra>(p => p.Regras)
                .WithRequired(r => r.Premiacao)
                .HasForeignKey(r => r.PremiacaoID)
                .WillCascadeOnDelete(true);
            modelBiulder.Entity<Premiacao>()
                .HasMany<TelespectadorParticipante>(p => p.Vencedores)
                .WithMany(t => t.PremiacoesGanhadas)
                .Map(t => t.ToTable("Premiacao_TelespcGanhador"));
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasOptional<Marca>(p => p.MarcaEscolhida)
                .WithMany(m => m.ParticipacoesDeTelespectadoresQueEscolheramEstaMarca)
                .HasForeignKey(p => p.MarcaEscolhidaID)
                .WillCascadeOnDelete(false);
            modelBiulder.Entity<ParticipacaoDoTelespectador>()
                .HasOptional<Marca>(p => p.MarcaPublicada)
                .WithMany(m => m.ParticipacoesDeTelespectadoresQueMarcaramEstaMarcaComoPublicada)
                .HasForeignKey(p => p.MarcaPublicadaID)
                .WillCascadeOnDelete(false);
        }

    }
}