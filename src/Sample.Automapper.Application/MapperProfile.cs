﻿    using AutoMapper;
using Sample.Automapper.Application.Entities;
using Sample.Automapper.Application.ViewModels;

namespace Sample.Automapper.Application;

public class MapperProfile : Profile
{
    public MapperProfile()
    {
        //Client
        CreateMap<Client, ClientViewModel>().ReverseMap();

        //Group
        CreateMap<Group, GroupViewModel>().ReverseMap()
            .ForMember(dest => dest.Description, src => src.Ignore())
            .AfterMap((src, dest) =>
            {
                dest.CreatedAt = DateTime.Now;
                dest.Description = dest.Name;
            });
    }
}