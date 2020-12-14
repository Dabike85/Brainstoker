using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBramStoker.Models;

namespace ProjetoBramStoker.Mapping
{
    public class EnderecoMap : IEntityTypeConfiguration<Endereco>
    {
        public void Configure(EntityTypeBuilder<Endereco> builder)
        {
            builder.ToTable("Endereco", "db_projetobramstoker");

            builder.HasKey(c => c.EnderecoID).HasName("EnderecoID");

            builder.Property(c => c.Rua).HasMaxLength(50);
            builder.Property(c => c.Numero);
            builder.Property(c => c.Complemento).HasMaxLength(50);
            builder.Property(c => c.CEP).HasMaxLength(20);
            builder.Property(c => c.Bairro).HasMaxLength(50);
        }
    }
}