using RestConnection.DTOs;
using RestConnection.Models;

namespace RestConnection.Interfaces
{
    public interface IBrasilAPIService
    {
        Task<ResponseDTO<EnderecoModel>> BuscarEnderecoCEP(string cep);
        Task<ResponseDTO<List<BancoModel>>> BuscarBancos();
        Task<ResponseDTO<BancoModel>> BuscarBanco(string codigoBanco);
    }
}
