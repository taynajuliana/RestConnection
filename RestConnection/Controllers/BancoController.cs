using Microsoft.AspNetCore.Mvc;
using RestConnection.Interfaces;
using System.Net;

namespace RestConnection.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class BancoController : Controller
    {
        private readonly IBancoService _bancoService;
        public BancoController(IBancoService bancoService)
        {
            _bancoService = bancoService;
        }

        [HttpGet("BuscarBanco/{codigoBanco}")]
        [ProducesResponseType(StatusCodes.Status200OK)] // Retorno 200 OK com os dados
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // Retorno 400 em caso de erro do cliente
        [ProducesResponseType(StatusCodes.Status404NotFound)] // Retorno 404 se o CEP não for encontrado
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] // Retorno 500 para erros internos
        public async Task<ActionResult> BuscarBanco(string codigoBanco)
        {
            var response = await _bancoService.BuscarBanco(codigoBanco);

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.Dados);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.Erro);
            }
        }
        [HttpGet("BuscarBancos")]
        [ProducesResponseType(StatusCodes.Status200OK)] // Retorno 200 OK com os dados
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // Retorno 400 em caso de erro do cliente
        [ProducesResponseType(StatusCodes.Status404NotFound)] // Retorno 404 se o CEP não for encontrado
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] // Retorno 500 para erros internos
        public async Task<ActionResult> BuscarBancos()
        {
            var response = await _bancoService.BuscarBancos();

            if (response.CodigoHttp == HttpStatusCode.OK)
            {
                return Ok(response.Dados);
            }
            else
            {
                return StatusCode((int)response.CodigoHttp, response.Erro);
            }
        }
    }
}
