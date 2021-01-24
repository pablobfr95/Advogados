using Dominio.Endereco;
using Repositorio.Contexto;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Repositorio.Implementacao
{
    public class EnderecoRepositorio : BaseRepositorio<Endereco>, IEnderecoRepositorio
    {
        private readonly AdvogadoContexto _contexto;
        public EnderecoRepositorio(AdvogadoContexto contexto) : base(contexto)
        {
            _contexto = contexto;
        }

    }
}
