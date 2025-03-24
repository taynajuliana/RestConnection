using AutoMapper;
using RestConnection.DTOs;

namespace RestConnection.Mapping
{
    public class EnderecoMap : Profile
    {
        public EnderecoMap()
        {
            CreateMap(typeof(ResponseDTO<>), typeof(ResponseDTO<>));
            CreateMap<EnderecoResponse, EnderecoModel>().ReverseMap();
            CreateMap<EnderecoModel, EnderecoResponse>().ReverseMap();
            //CreateMap<ResponseDTO<EnderecoResponse>, ResponseDTO<EnderecoResponse>>();
        }
    }
}
