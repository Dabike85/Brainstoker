using Microsoft.EntityFrameworkCore;
using ProjetoBramStoker.Mapping;
using ProjetoBramStoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker
{
    public class BramStokerContext : DbContext
    {
        public DbSet<Usuario> Usuario { get; set; }
        public DbSet<Produto> Produto { get; set; }
        public DbSet<Endereco> Endereco { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source='201.62.57.93';User ID=laboratorio;Password=@laboratorio*");


            //optionsBuilder.UseSqlServer(@"Data Source='201.62.57.93';User ID=laboratorio;Password=@laboratorio*");
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ProdutoMap());
            builder.ApplyConfiguration(new EnderecoMap());
            builder.ApplyConfiguration(new UsuarioMap());
        }
    }
}
