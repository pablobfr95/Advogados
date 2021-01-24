using Dominio.Advogado;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class AdvogadoViewModel
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Nome possui tamanho máximo de 50 caracteres !")]
        public string Nome { get; set; }
        [Required]
        [MaxLength(40, ErrorMessage = "Senioridade possui tamanho máximo de 40 caracteres !")]
        public string Senioridade { get; set; }
        public virtual IEnumerable<EnderecoViewModel> Enderecos { get; set; }

        public static Advogado ModelParaCriarEntidade(AdvogadoViewModel model)
        {
            return new Advogado(model.Nome, model.Senioridade);
        }
        public static Advogado ModelParaEditarEntidade(AdvogadoViewModel model)
        {
            
            var advogado = new Advogado(model.Id, model.Nome, model.Senioridade);
            advogado.Enderecos = EnderecoViewModel.ListaModelParaEntidade(model.Enderecos, model.Id);
            return advogado;
        }

        public static AdvogadoViewModel EntidadeParaModel(Advogado advogado)
        {
            return new AdvogadoViewModel
            {
                Id = advogado.Id,
                Nome = advogado.Nome,
                Senioridade = advogado.Senioridade
            };
        }

    }
}
