﻿using Dominio.Endereco;
using Repositorio.Interface;
using System;
using System.Collections.Generic;
using System.Text;

namespace Servico
{
    public class EnderecoService : BaseServico<Endereco>, IEnderecoServico
    {
        private readonly IEnderecoRepositorio _repositorio;
        public EnderecoService(IEnderecoRepositorio repositorio) : base(repositorio)
        {
            _repositorio = repositorio;
        }
    }
}
