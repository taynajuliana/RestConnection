using AutoMapper;
using RestConnection.DTOs;
using RestConnection.Interfaces;
using RestConnection.Models;
using System.Runtime.ConstrainedExecution;

namespace RestConnection.Service
{
    public class BancoService : IBancoService
    {
        private readonly IMapper _mapper;
        private readonly IBrasilAPIService _brasilApi;

        public BancoService(IMapper mapper, IBrasilAPIService brasilApi)
        {
            _mapper = mapper;
            _brasilApi = brasilApi;
        }
        public async Task<ResponseDTO<BancoModel>> BuscarBanco(string codigoBanco)
        {
            var banco = await _brasilApi.BuscarBanco(codigoBanco);
            return _mapper.Map<ResponseDTO<BancoModel>>(banco);
        }

        public async Task<ResponseDTO<List<BancoModel>>> BuscarBancos()
        {
            var banco = await _brasilApi.BuscarBancos();
            return _mapper.Map<ResponseDTO<List<BancoModel>>>(banco);
        }
    }
}
