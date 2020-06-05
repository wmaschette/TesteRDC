using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using ProblemaSinais;

namespace DesafioRdc.Controllers
{
    public class ProblemaSinaisController : BaseController
    {
        private readonly ISinais _sinais;

        public ProblemaSinaisController(ISinais sinais)
        {
            _sinais = sinais;
        }

        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult VerificarSinais(string[] dados)
        {
            if (dados == null)
                return TratarRetornoErro();

            if (dados.Count() <= 0)
                return TratarRetornoErro();

            var dadosRetorno = _sinais.ValidarSinais(dados);

            if (dadosRetorno == new List<DadosSinais>())
                return TratarRetornoErro();

            return Json(dadosRetorno);
        }
    }
}
