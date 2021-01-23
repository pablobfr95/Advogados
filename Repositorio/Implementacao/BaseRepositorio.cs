using Dominio.Base;
using Microsoft.EntityFrameworkCore;
using Repositorio.Contexto;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Repositorio.Implementacao
{
    public abstract class BaseRepositorio<T> : IDisposable, IBaseRepositorio<T> where T : EntidadeBase
    {
        private readonly AdvogadoContexto _contexto;

        public BaseRepositorio(AdvogadoContexto contexto)
        {
            _contexto = contexto;
        }

        public virtual void Atualizar(T entidade)
        {
            _contexto.Entry(entidade).State = EntityState.Modified;
            _contexto.SaveChanges();
        }

        public virtual T BuscarPorId(int id)
        {
            return _contexto.Set<T>().AsNoTracking().FirstOrDefault(t => t.Id == id);
        }

        public virtual void Dispose()
        {
            _contexto.Dispose();
        }

        public virtual void Excluir(T entidade)
        {
            _contexto.Set<T>().Remove(entidade);
            _contexto.SaveChanges();
        }

        public virtual void Incluir(T entidade)
        {
            _contexto.Set<T>().Add(entidade);
            _contexto.SaveChanges();
        }

        public virtual IEnumerable<T> Listar()
        {
           return _contexto.Set<T>().AsNoTracking().ToList();
        }
    }
}
