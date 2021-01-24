using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Advogado;
using Microsoft.AspNetCore.Mvc;

namespace Web.Controllers
{
    public class AdvogadoController : Controller
    {
        private readonly IAdvogadoServico _servico;

        public AdvogadoController(IAdvogadoServico servico)
        {
            _servico = servico;
        }
       
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Cadastrar()
        {
            return View("Formulario");
        }
    }
}
