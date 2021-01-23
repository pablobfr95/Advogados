using Dominio.Advogado;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class AdvogadoServico : BaseServico<Advogado>, IAdvogadoServico
    {
        private readonly IAdvogadoRepositorio _repositorio;
        public AdvogadoServico(IAdvogadoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
