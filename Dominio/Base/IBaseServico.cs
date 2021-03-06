﻿using Dominio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Endereco
{
    public interface IBaseServico<T> where T : EntidadeBase
    {
        void Incluir(T entidade);
        void Atualizar(T entidade);
        void Excluir(T entidade);
        T BuscarPorId(int id);
        IEnumerable<T> Listar();
    }
}
