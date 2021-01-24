using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Advogado;
using Dominio.Endereco;
using Microsoft.AspNetCore.Mvc;
using Web.Models;

namespace Web.Controllers
{
    public class AdvogadoController : Controller
    {
        private readonly IAdvogadoServico _servico;
        private readonly IEnderecoServico _servicoEndereco;

        public AdvogadoController(IAdvogadoServico servico, IEnderecoServico servicoEndereco)
        {
            _servico = servico;
            _servicoEndereco = servicoEndereco;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        
        public IActionResult Cadastrar()
        {
            return View("Formulario", new AdvogadoViewModel());
        }

        [HttpGet("Editar")]
        public IActionResult Editar(int id)
        {
            try
            {
                var advogado = _servico.BuscarPorId(id);
                if (advogado == null) return NotFound();
                var advogadoModel = AdvogadoViewModel.EntidadeParaModel(advogado);
                advogadoModel.Enderecos = EnderecoViewModel.ListaEntidadeParaModel(advogado.Enderecos);
                return View("Formulario", advogadoModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpPost("Editar")]
        public IActionResult Editar([FromBody] AdvogadoViewModel model)
        {

            try
            {
                var advogado = AdvogadoViewModel.ModelParaEditarEntidade(model);
                var advogadoAntigo = _servico.BuscarPorId(advogado.Id);
                if (advogadoAntigo == null) return NotFound("Advogado não encontrado !");
                _servico.Atualizar(advogado);
                if (advogadoAntigo.Enderecos != null)
                {
                    var enderecosAntigos = advogadoAntigo.Enderecos.ToList();
                    for (int i = 0; i < advogadoAntigo.Enderecos.Count(); i++)
                    {
                        _servicoEndereco.Excluir(enderecosAntigos[i]);
                    }
                }
                var enderecosNovos = EnderecoViewModel.ListaModelParaEntidade(model.Enderecos, advogado.Id);
                foreach (var item in enderecosNovos)
                {
                    _servicoEndereco.Incluir(item);
                }

                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }

        }

        [HttpPost("Cadastrar")]
        public IActionResult Cadastrar([FromBody] AdvogadoViewModel model)
        {
            try
            {
                var advogado = AdvogadoViewModel.ModelParaCriarEntidade(model);
                _servico.Incluir(advogado);
                foreach (var item in model.Enderecos)
                {
                    var endereco = EnderecoViewModel.ModelParaEntidade(item, advogado.Id);
                    _servicoEndereco.Incluir(endereco);
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("Listar")]
        public IActionResult Listar()
        {
            try
            {
                var advogados = _servico.Listar();
                var advogadosModel = new List<AdvogadoViewModel>();
                foreach (var item in advogados)
                {
                    var model = AdvogadoViewModel.EntidadeParaModel(item);
                    model.Enderecos = EnderecoViewModel.ListaEntidadeParaModel(item.Enderecos);
                    advogadosModel.Add(model);
                }
                return new JsonResult(advogadosModel);

            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }

        [HttpGet("BuscarPorId")]
        public IActionResult BuscarPorId(int id)
        {
            try
            {
                var advogado = _servico.BuscarPorId(id);
                if (advogado == null) return NotFound();
                var advogadoModel = AdvogadoViewModel.EntidadeParaModel(advogado);
                advogadoModel.Enderecos = EnderecoViewModel.ListaEntidadeParaModel(advogado.Enderecos);
                return new JsonResult(advogadoModel);
            }
            catch (Exception ex)
            {
                return StatusCode(500, ex.Message);
            }
        }
    }
}
