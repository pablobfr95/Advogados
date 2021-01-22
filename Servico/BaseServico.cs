using Dominio.Endereco;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public abstract class BaseServico<T> : IBaseServico<T> where T : class
    {
        public virtual void Atualizar(T entidade)
        {
            throw new NotImplementedException();
        }

        public virtual T BuscarPorId(int id)
        {
            throw new NotImplementedException();
        }

        public virtual void Excluir(T entidade)
        {
            throw new NotImplementedException();
        }

        public virtual void Incluir(T entidade)
        {
            throw new NotImplementedException();
        }

        public virtual IEnumerable<T> Listar()
        {
            throw new NotImplementedException();
        }
    }
}
