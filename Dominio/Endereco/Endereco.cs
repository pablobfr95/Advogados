using Dominio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Endereco
{
    public class Endereco : EntidadeBase
    {
        public string Logradouro { get;private  set; }
        public string Bairro { get;private  set; }
        public string Cidade { get;private  set; }
        public string Estado { get;private  set; }
        public int AdvogadoId { get;private  set; }
        public virtual Advogado.Advogado Advogado { get; set; }

        protected Endereco()
        {

        }

        public Endereco(string pStrLogradouro, string pStrBairro, string pStrCidade, string pStrEstado, int pIntAdvogadoId)
        {
            ValidarParaInclusao(pStrLogradouro, pStrBairro, pStrCidade, pStrEstado, pIntAdvogadoId);
            Logradouro = pStrLogradouro;
            Bairro = pStrBairro;
            Cidade = pStrCidade;
            Estado = pStrEstado;
            AdvogadoId = pIntAdvogadoId;
        }

        public Endereco(int pIntId, string pStrLogradouro, string pStrBairro, string pStrCidade, string pStrEstado, int pIntAdvogadoId)
        {
            ValidarParaAlteracao(pIntId, pStrLogradouro, pStrBairro, pStrCidade, pStrEstado, pIntAdvogadoId);
            Id = pIntId;
            Logradouro = pStrLogradouro;
            Bairro = pStrBairro;
            Cidade = pStrCidade;
            Estado = pStrEstado;
            AdvogadoId = pIntAdvogadoId;
        }

        private void ValidarParaInclusao(string pStrLogradouro, string pStrBairro, string pStrCidade, string pStrEstado, int pIntAdvogadoId)
        {
            if (string.IsNullOrEmpty(pStrLogradouro) || pStrLogradouro.Length > 50) throw new ArgumentException("Logradouro Inválido !");
            if (string.IsNullOrEmpty(pStrBairro) || pStrBairro.Length > 50) throw new ArgumentException("Bairro Inválido !");
            if (string.IsNullOrEmpty(pStrCidade) || pStrCidade.Length > 40) throw new ArgumentException("cidade Inválido !");
            if (string.IsNullOrEmpty(pStrEstado) || pStrEstado.Length > 40) throw new ArgumentException("Estado Inválido !");
            if (pIntAdvogadoId == 0) throw new ArgumentException("Informe um advogado para poder cadastrar um Endereço !");
        }

        private void ValidarParaAlteracao(int pIntId, string pStrLogradouro, string pStrBairro, string pStrCidade, string pStrEstado, int pIntAdvogadoId)
        {
            if (pIntId == 0) throw new ArgumentException("Informe um id de Endereço !");
            if (string.IsNullOrEmpty(pStrLogradouro) || pStrLogradouro.Length > 50) throw new ArgumentException("Logradouro Inválido !");
            if (string.IsNullOrEmpty(pStrBairro) || pStrBairro.Length > 50) throw new ArgumentException("Bairro Inválido !");
            if (string.IsNullOrEmpty(pStrCidade) || pStrCidade.Length > 40) throw new ArgumentException("cidade Inválido !");
            if (string.IsNullOrEmpty(pStrEstado) || pStrEstado.Length > 40) throw new ArgumentException("Estado Inválido !");
            if (pIntAdvogadoId == 0) throw new ArgumentException("Informe um advogado para poder cadastrar um Endereço !");
        }
    }
}
