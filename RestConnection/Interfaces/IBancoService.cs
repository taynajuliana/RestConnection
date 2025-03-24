using RestConnection.DTOs;
using RestConnection.Models;

namespace RestConnection.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseDTO<List<BancoModel>>> BuscarBancos();
        Task<ResponseDTO<BancoModel>> BuscarBanco(string codigoBanco);
    }
}
