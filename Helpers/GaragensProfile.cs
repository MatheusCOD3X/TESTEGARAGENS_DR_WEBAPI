using AutoMapper;
using TESTEGARAGENS_DR_WEBAPI.Dtos;
using TESTEGARAGENS_DR_WEBAPI.Models;

namespace TESTEGARAGENS_DR_WEBAPI.Helpers
{
    public class GaragensProfile : Profile
    {
        public GaragensProfile()
        {
            CreateMap<Garagem, GaragemDTO>().ReverseMap();
        }
    }
}