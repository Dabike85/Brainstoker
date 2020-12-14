using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ProjetoBramStoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

public class CidadeConfig : IEntityTypeConfiguration<Cidade>
{
    public void Configure(EntityTypeBuilder<Cidade> builder)
    {
        builder.ToTable("meuapphugo_AvaliarServico");
        builder.HasKey("IdAvaliacao");


        builder.Property("Descricao").HasColumnName("Descricao").HasColumnType("int");
        builder.Property("NomeCliente").HasColumnName("NomeCliente").HasColumnType("varchar(100)");
        builder.Property("NomeTrabalhador").HasColumnName("NomeTrabalhado").HasColumnType("varchar100)");
        builder.Property("IdServico").HasColumnName("IdServico").HasColumnType("int");
    }
}