using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RestConnection.Interfaces;
using System.Net;
using System.Security.Cryptography;
using System.Text;

namespace RestConnection.Controllers
{
    [ApiController]
    [Route("api/v1/[controller]")]
    public class EnderecoController : Controller
    {
       private readonly IEnderecoService _enderecoService;
        public EnderecoController(IEnderecoService enderecoService)
        {
            _enderecoService = enderecoService;
        }

        [HttpGet("{cep}")]
        [ProducesResponseType(StatusCodes.Status200OK)] // Retorno 200 OK com os dados
        [ProducesResponseType(StatusCodes.Status400BadRequest)] // Retorno 400 em caso de erro do cliente
        [ProducesResponseType(StatusCodes.Status404NotFound)] // Retorno 404 se o CEP não for encontrado
        [ProducesResponseType(StatusCodes.Status500InternalServerError)] // Retorno 500 para erros internos
        public async Task<ActionResult> BuscarEnderecoCEP(string cep)
        {
            var response = await _enderecoService.BuscarEnderecoCEP(cep);

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
