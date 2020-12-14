using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBramStoker.Models;

namespace ProjetoBramStoker.Mapping
{
    public class UsuarioMap : IEntityTypeConfiguration<Usuario>
    {
        public void Configure(EntityTypeBuilder<Usuario> builder)
        {
            builder.ToTable("Usuario", "db_projetobramstoker");

            builder.HasKey(c => c.UsuarioID).HasName("UsuarioID");

            builder.Property(c => c.Username).HasMaxLength(50);
            builder.Property(c => c.Senha).HasMaxLength(50);
            builder.Property(c => c.Email).HasMaxLength(100);

            builder.HasOne(f => f.Endereco)
                    .WithMany()
                    .HasForeignKey(p => p.EnderecoID);

        }
    }
}