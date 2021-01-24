using Dominio.Endereco;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Web.Models
{
    public class EnderecoViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Tamanho Máximo de 50 caracteres !")]
        public string Logradouro { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Tamanho Máximo de 50 caracteres !")]
        public string Bairro { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Tamanho Máximo de 40 caracteres !")]
        public string Cidade { get; set; }
        [Required]
        [MaxLength(50, ErrorMessage = "Tamanho Máximo de 40 caracteres !")]
        public string Estado { get; set; }

        public static Endereco ModelParaEntidade(EnderecoViewModel model, int pIntAdvogadoId)
        {
            return new Endereco(model.Logradouro, model.Bairro, model.Cidade, model.Estado, pIntAdvogadoId);
        }
    }
}
