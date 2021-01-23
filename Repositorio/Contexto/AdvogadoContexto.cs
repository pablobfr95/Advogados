using Dominio.Advogado;
using Dominio.Endereco;
using Microsoft.EntityFrameworkCore;
using Repositorio.EntityConfig;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Contexto
{
    public class AdvogadoContexto : DbContext
    {
        public AdvogadoContexto( DbContextOptions<AdvogadoContexto> options) : base(options)
        {
        }

        public DbSet<Advogado> Advogado { get; set; }
        public DbSet<Endereco> Endereco { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {

            base.OnModelCreating(builder);

            // Your custom configs here
            new AdvogadoConfig(builder.Entity<Advogado>());
            new EnderecoConfig(builder.Entity<Endereco>());

        }
    }
}
