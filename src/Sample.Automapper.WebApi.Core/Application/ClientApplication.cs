using AutoMapper;
using Sample.Automapper.WebApi.Core.Abstractions;
using Sample.Automapper.WebApi.Core.Entities;
using Sample.Automapper.WebApi.Core.ViewModels;

namespace Sample.Automapper.WebApi.Core.Application;

public class ClientApplication : IClientApplication
{
    private readonly IMapper _mapper;

    public ClientApplication(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<ClientViewModel> AddClient(ClientViewModel model)
    {
        var entity = _mapper.Map<Client>(model);

        //call repository

        var result = _mapper.Map<ClientViewModel>(entity);

        return result;
    }
}