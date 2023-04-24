using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Restaurante.API.Models;

namespace Restaurante.API.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Mesa>? Mesas { get; set; }
        public DbSet<Garcon> Garcons { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        public DbSet<Atendimento> Atendimentos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("DataSource=tds.db;Cache=Shared");

        protected override void OnModelCreating(ModelBuilder modelBuilder){
            modelBuilder.Entity<Mesa>().ToTable("Mesas");
            modelBuilder.Entity<Garcon>().ToTable("Garcons");
            modelBuilder.Entity<Categoria>().ToTable("Categorias");
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            modelBuilder.Entity<Atendimento>().ToTable("Atendimentos");
            modelBuilder.Entity<Atendimento>()
            .HasMany(a => a.Produtos)
            .WithMany()
            .UsingEntity(j => j.ToTable("AtendimentoProduto"));
        }

        
    }
}