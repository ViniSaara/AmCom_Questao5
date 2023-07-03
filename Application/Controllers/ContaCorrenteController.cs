using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NSubstitute.ReturnsExtensions;
using Questao5.Application.Commands.Requests;
using Questao5.Application.Commands.Responses;
using Questao5.Application.Handlers;
using System.Net;
using System.Web;

namespace Questao5.Application.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ContaCorrenteController : ControllerBase
    {
        private ICriarMovimentacaoHandler _handler;

        public ContaCorrenteController(ICriarMovimentacaoHandler handler)
        {
            _handler = handler;
        }

        [HttpPost]
        public IActionResult CriarMovimentacao([FromBody]CriarMovimentacaoRequest command)
        {
            try
            {
                CriarMovimentacaoResponse resultado = _handler.Handle(command);

                return Ok(resultado);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
    }
}
