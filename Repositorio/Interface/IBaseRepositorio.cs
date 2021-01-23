using Dominio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Interface
{
    public interface IBaseRepositorio<T> where T : EntidadeBase
    {
        void Incluir(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
        T BuscarPorId(int id);
        IEnumerable<T> Listar();
    }
}
