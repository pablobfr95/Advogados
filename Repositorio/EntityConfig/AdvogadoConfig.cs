using Dominio.Advogado;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.EntityConfig
{
    public class AdvogadoConfig
    {
        public AdvogadoConfig(EntityTypeBuilder<Advogado> builder)
        {
            builder.HasKey(a => a.Id);

            builder.Property(a => a.Id).ValueGeneratedOnAdd();

            builder.Property(a => a.Nome).HasMaxLength(50).IsRequired();

            builder.Property(a => a.Senioridade).HasMaxLength(40).IsRequired();
        }
    }
}
