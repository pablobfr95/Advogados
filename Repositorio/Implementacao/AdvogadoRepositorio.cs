using Dominio.Advogado;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Implementacao
{
    public class AdvogadoRepositorio : BaseRepositorio<Advogado>, IAdvogadoRepositorio
    {
        private readonly AdvogadoContexto _contexto;

        public AdvogadoRepositorio(AdvogadoContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

        public override Advogado BuscarPorId(int id)
        {
            return _contexto.Advogado.Include(a => a.Enderecos).AsNoTracking().FirstOrDefault(a => a.Id == id);
        }

        public override IEnumerable<Advogado> Listar()
        {
            return _contexto.Advogado.Include(a => a.Enderecos).AsNoTracking();
        }
    }
}
