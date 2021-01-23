using Dominio.Endereco;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.EntityConfig
{
    public class EnderecoConfig
    {
        public EnderecoConfig(EntityTypeBuilder<Endereco> builder)
        {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Logradouro).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Bairro).IsRequired().HasMaxLength(50);

            builder.Property(e => e.Cidade).IsRequired().HasMaxLength(40);

            builder.Property(e => e.Estado).IsRequired().HasMaxLength(40);

            builder.HasOne(e => e.Advogado).WithMany(a => a.Enderecos).HasForeignKey(e => e.AdvogadoId).IsRequired().OnDelete(DeleteBehavior.Cascade);
        }
    }
}
