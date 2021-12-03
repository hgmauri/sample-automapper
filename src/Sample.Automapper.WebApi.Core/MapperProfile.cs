using AutoMapper;
using Sample.Automapper.WebApi.Core.Entities;
using Sample.Automapper.WebApi.Core.ViewModels;

namespace Sample.Automapper.WebApi.Core;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        CreateMap<ClientViewModel, Client>().ReverseMap();
    }
}