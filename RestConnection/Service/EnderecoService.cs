using AutoMapper;
using RestConnection.DTOs;
using RestConnection.Interfaces;
using System.Runtime.ConstrainedExecution;

namespace RestConnection.Service
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPIService _brasilApi;

        public EnderecoService(IMapper mapper, IBrasilAPIService brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }

        public async Task<ResponseDTO<EnderecoResponse>> BuscarEnderecoCEP(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoCEP(cep);
            return _mapper.Map<ResponseDTO<EnderecoResponse>>(endereco);
        }
    }
}
