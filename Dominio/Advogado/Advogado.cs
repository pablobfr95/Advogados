using Dominio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Advogado
{
    public class Advogado : EntidadeBase
    {
        public string Nome { get;private set; }
        public string Senioridade { get;private set; }
        public virtual IEnumerable<Endereco.Endereco> Enderecos { get;private set;  }

        protected Advogado()
        {

        }

        public Advogado(string pStrNome, string pStrSenioridade)
        {
            ValidarParaInclusao(pStrNome, pStrSenioridade);
            Nome = pStrNome;
            Senioridade = pStrSenioridade;
        }
        public Advogado(int pIntId, string pStrNome, string pStrSenioridade)
        {
            ValidarParaAlteracao(pIntId, pStrNome, pStrSenioridade);
            Id = pIntId;
            Nome = pStrNome;
            Senioridade = pStrSenioridade;
        }

        private void ValidarParaInclusao(string pStrNome, string pStrSenioridade)
        {
            if (string.IsNullOrEmpty(pStrNome) || pStrNome.Length > 50) throw new ArgumentException("Nome de cliente inválido !");
            if (string.IsNullOrEmpty(pStrSenioridade) || pStrSenioridade.Length > 40) throw new ArgumentException("Senioridade inválida !");
        }

        private void ValidarParaAlteracao(int pIntId, string pStrNome, string pStrSenioridade)
        {
            if (pIntId == 0) throw new ArgumentException("Id inválido !");
            if (string.IsNullOrEmpty(pStrNome) || pStrNome.Length > 50) throw new ArgumentException("Nome de cliente inválido !");
            if (string.IsNullOrEmpty(pStrSenioridade) || pStrSenioridade.Length > 40) throw new ArgumentException("Senioridade inválida !");
        }
    }
}
