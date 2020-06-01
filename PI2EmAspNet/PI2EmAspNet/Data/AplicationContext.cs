using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using PI2EmAspNet.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace PI2EmAspNet.Data {
    public class AplicationContext : DbContext {

        public AplicationContext(DbContextOptions<AplicationContext> options) : base(options) {

        }

        public DbSet<Classificacao> Classificacoes { get; set; }
        public DbSet<Diretor> Diretores { get; set; }
        public DbSet<Desenvolvedora> Desenvolvedoras { get; set; }
        public DbSet<Jogo> Jogos { get; set; }
        public JogoGenero JogoGeneros { get; set; }
        public DbSet<ModoJogo> ModoJogos { get; set; }
        public DbSet<Genero> Generos { get; set; }
        public DbSet<Plataforma> Plataformas { get; set; }
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Sugestao> Sugestoes { get; set; }
        public DbSet<TipoUsuario> TipoUsuarios { get; set; }
        public DbSet<Usuario> Usuarios { get; set; }

        


        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Classificacao>().HasKey(p => p.Id);
            modelBuilder.Entity<Classificacao>().Property(p => p.NomeClassificacao).IsRequired()
                .HasMaxLength(5);
            modelBuilder.Entity<Classificacao>().HasMany(c => c.Jogos).WithOne(cl => cl.Classificacao);
            modelBuilder.Entity<Desenvolvedora>().HasKey(p => p.Id);
            modelBuilder.Entity<Desenvolvedora>().Property(p => p.NomeDesenvolvedora).IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Desenvolvedora>().HasMany(c => c.Jogos).WithOne(de => de.Desenvolvedora);
            modelBuilder.Entity<Diretor>().HasKey(p => p.Id);
            modelBuilder.Entity<Diretor>().Property(p => p.NomeDiretor).IsRequired()
                .HasMaxLength(30);
            modelBuilder.Entity<Diretor>().HasMany(c => c.Jogos).WithOne(d => d.Diretor);
            modelBuilder.Entity<ModoJogo>().HasKey(p => p.Id);
            modelBuilder.Entity<ModoJogo>().Property(p => p.NomeModo).IsRequired()
                .HasMaxLength(20);
            modelBuilder.Entity<ModoJogo>().HasMany(c => c.Jogos).WithOne(d => d.ModoJogo);
            modelBuilder.Entity<JogoGenero>()
       .HasKey(jg => new { jg.JogoId, jg.GeneroId });
            modelBuilder.Entity<JogoGenero>()
                .HasOne(jg => jg.Jogo)
                .WithMany(j => j.JogoGeneros)
                .HasForeignKey(jg => jg.JogoId);
            modelBuilder.Entity<JogoGenero>()
                .HasOne(jg => jg.Genero)
                .WithMany(c => c.JogoGeneros)
                .HasForeignKey(jg => jg.GeneroId);
            modelBuilder.Entity<JogoPlataforma>()
      .HasKey(jg => new { jg.JogoId, jg.PlataformaId });
            modelBuilder.Entity<JogoPlataforma>()
                .HasOne(jg => jg.Jogo)
                .WithMany(j => j.JogoPlataformas)
                .HasForeignKey(jg => jg.JogoId);
            modelBuilder.Entity<JogoPlataforma>()
                .HasOne(jg => jg.Plataforma)
                .WithMany(c => c.JogoPlataformas)
                .HasForeignKey(jg => jg.PlataformaId);
            modelBuilder.Entity<Usuario>().HasKey(u => u.Id);
            modelBuilder.Entity<Usuario>().HasIndex(u => u.Apelido).IsUnique();
            modelBuilder.Entity<Usuario>().HasIndex(u => u.Email).IsUnique();
            modelBuilder.Entity<Usuario>().Property(u => u.Apelido).IsRequired();
            modelBuilder.Entity<Usuario>().Property(u => u.Email).IsRequired();
            modelBuilder.Entity<Usuario>().Property(u => u.Apelido).HasMaxLength(20);
            modelBuilder.Entity<Usuario>().Property(u => u.Email).HasMaxLength(50);
            modelBuilder.Entity<Usuario>().HasOne(u => u.TipoUsuario).WithMany(tu => tu.Usuarios);
            modelBuilder.Entity<Review>().HasKey(r => r.Id);
            modelBuilder.Entity<Review>().HasOne(r => r.Usuario).WithMany(u => u.Reviews).IsRequired();
            modelBuilder.Entity<Sugestao>().HasKey(s => s.Id);
            modelBuilder.Entity<Sugestao>().HasOne(s => s.Usuario).WithMany(u => u.Sugestoes).IsRequired();
            modelBuilder.Entity<TipoUsuario>().HasKey(tu => tu.Id);
            modelBuilder.Entity<TipoUsuario>().Property(tu => tu.NomeTipo).HasMaxLength(15).IsRequired();
        }
    }
}
