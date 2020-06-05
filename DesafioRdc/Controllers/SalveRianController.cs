using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dominio.Entities;
using Dominio.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace DesafioRdc.Controllers
{
    public class SalveRianController : BaseController
    {
        private readonly ISoldados _soldados;

        public SalveRianController(ISoldados soldados)
        {
            _soldados = soldados;
        }

        // GET: SalveRianController
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult VerificarSobrevivente(int? quantidade)
        {
            if (quantidade == null)
                return TratarRetornoErro("Nenhum valor inserido!");

            if (quantidade < 2)
                return TratarRetornoErro("Informe uma quantidade maior de soldados.");

            var retorno = _soldados.VerificarSoldadoSobrevivente((int)quantidade);

            if (retorno.PosicaoSobrevivente == 0)
                return TratarRetornoErro();

            return Json(retorno);
        }
    }
}
