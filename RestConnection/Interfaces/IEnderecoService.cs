using RestConnection.DTOs;

namespace RestConnection.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseDTO<EnderecoResponse>> BuscarEnderecoCEP(string cep);
    }
}
