using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBramStoker.Models;

namespace ProjetoBramStoker.Mapping
{
    public class ProdutoMap : IEntityTypeConfiguration<Produto>
    {
        public void Configure(EntityTypeBuilder<Produto> builder)
        {
            builder.ToTable("Produto", "db_projetobramstoker");

            builder.HasKey(c => c.ProdutoID).HasName("ProdutoID");

            builder.Property(c => c.Imagem).HasMaxLength(200);
            builder.Property(c => c.Titulo).HasMaxLength(50);
            builder.Property(c => c.Descricao).HasMaxLength(150);
            builder.Property(c => c.Modelo).HasMaxLength(150);
            builder.Property(c => c.Cor).HasMaxLength(150);

            //builder.Property(c => c.EnderecoID);
            builder.HasOne(f => f.Usuario)
                    .WithMany()
                    .HasForeignKey(p => p.UsuarioID);

        }
    }
}