using AutoMapper;
using RestConnection.DTOs;
using RestConnection.Models;

namespace RestConnection.Mapping
{
    public class BancoMap : Profile
    {
        public BancoMap()
        {
            CreateMap(typeof(ResponseDTO<>), typeof(ResponseDTO<>));
            CreateMap<BancoResponse, BancoModel>().ReverseMap();
            CreateMap<BancoModel, BancoResponse>().ReverseMap();
        }
    }
}
