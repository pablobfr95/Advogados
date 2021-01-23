using Dominio.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio.Endereco
{
    public class Endereco : EntidadeBase
    {
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public int AdvogadoId { get; set; }
        public virtual Advogado.Advogado Advogado { get; set; }
    }
}
