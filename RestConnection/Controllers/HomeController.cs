using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Security.Cryptography;
using System.Text;

namespace RestConnection.Controllers
{
    public class HomeController : Controller
    {
        private readonly string publicKey = "38e3266b176edf790b1c961187a0cf32";
        private readonly string privateKey = "2a9481d2478a665aec7c243f334ecc68c8c4e19e";

        [HttpGet("{cep}")]
        public async Task<ActionResult> GetEndereco(string cep)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = $"https://viacep.com.br/ws/{cep}/json/";
                HttpResponseMessage response = await client.GetAsync(url);
                if (response.IsSuccessStatusCode)
                {
                    string jsonResult = await response.Content.ReadAsStringAsync();
                    EnderecoModel endereco = JsonConvert.DeserializeObject<EnderecoModel>(jsonResult);
                    return Ok(endereco);
                }
                else
                {
                    return BadRequest($"Erro ao consultar o CEP. {response.StatusCode}");
                }
            }
        }

    }
}
