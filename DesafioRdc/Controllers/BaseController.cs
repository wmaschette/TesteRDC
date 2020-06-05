using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace DesafioRdc.Controllers
{
    public class BaseController : Controller
    {
        protected JsonResult TratarRetornoErro(string mensagem = null)
        {
            string mensagemPadrao = "Ocorreu um erro, por favor entre em contato com o suporte";
            mensagem = mensagem == null ? mensagemPadrao : mensagem;
            Response.StatusCode = (int)HttpStatusCode.BadRequest;

            return Json(new { Erro = mensagem });
        }
    }
}
