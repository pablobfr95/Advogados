using Dominio.Advogado;
using Dominio.Endereco;
using Microsoft.EntityFrameworkCore;
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

    }
}
