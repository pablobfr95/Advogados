using Dominio.Base;
using Dominio.Endereco;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public abstract class BaseServico<T> : IBaseServico<T> where T : EntidadeBase
    {
        private readonly IBaseRepositorio<T> _repositorio;
        public BaseServico(IBaseRepositorio<T> repositorio)
        {
            _repositorio = repositorio;
        }

        public virtual void Atualizar(T entidade)
        {
             _repositorio.Atualizar(entidade);
        }

        public virtual T BuscarPorId(int id)
        {
            return _repositorio.BuscarPorId(id);
        }

        public virtual void Excluir(T entidade)
        {
            _repositorio.Excluir(entidade);
        }

        public virtual void Incluir(T entidade)
        {
            _repositorio.Incluir(entidade);
        }

        public virtual IEnumerable<T> Listar()
        {
            return _repositorio.Listar();
        }
    }
}
