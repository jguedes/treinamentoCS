﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Dominio;
namespace Web.Models
{
    public class AcerteAMarcaContext : DbContext
    {
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Marca> Marca { get; set; }
        public DbSet<CenaParaPropaganda> Cena { get; set; }
        public DbSet<TelespactadorParticipante> TelespactadorParticipante { get; set; }
        public DbSet<PropagandaMarcada> PropagandaMarcada { get; set; }
        public DbSet<Propaganda> Propaganda { get; set; }
        public DbSet<ProgramaDeTV> ProgramaDeTV { get; set; }
        public DbSet<Premiacao> Premiacao { get; set; }
        public DbSet<AcerteAMarca> AcerteAMarca { get; set; }

        public AcerteAMarcaContext() : base("AcerteamarcaDB")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBiulder)
        {
            base.OnModelCreating(modelBiulder);

            modelBiulder.Entity<Marca>()
                .HasMany<Produto>(m => m.Produtos);
            modelBiulder.Entity<Produto>()
                .HasMany<Marca>(p => p.Marcas);
            modelBiulder.Entity<CenaParaPropaganda>()
                .HasRequired<Produto>(r => r.Produto);
            modelBiulder.Entity<Propaganda>()
                .HasMany<Marca>(p => p.OpcoesDeMarcasParaProdutoNaCena);
            modelBiulder.Entity<ProgramaDeTV>()
                .HasMany<Propaganda>(p => p.Propagandas);
            modelBiulder.Entity<Premiacao>()
                .HasMany<Regra>(p => p.Regras);
            modelBiulder.Entity<PropagandaMarcada>()
                .HasRequired<Propaganda>(r => r.PropagandaVisualizada);
            modelBiulder.Entity<TelespactadorParticipante>()
                .HasMany<PropagandaMarcada>(t => t.PropagandasMarcadas);
            modelBiulder.Entity<AcerteAMarca>()
                .HasMany<ProgramaDeTV>(a => a.ProgramasDeTV);
            modelBiulder.Entity<AcerteAMarca>()
                .HasMany<TelespactadorParticipante>(a => a.TelespectadoresParticipantes);
            modelBiulder.Entity<AcerteAMarca>()
                .HasMany<Premiacao>(a => a.Premiacoes);
        }

        public System.Data.Entity.DbSet<Dominio.Regra> Regras { get; set; }
    }
}