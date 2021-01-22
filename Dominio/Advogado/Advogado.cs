using Dominio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Advogado
{
    public class Advogado : EntidadeBase
    {
        public string Nome { get; set; }
        public string Senioridade { get; set; }
        public virtual IEnumerable<Endereco.Endereco> Enderecos { get; set;  }
    }
}
