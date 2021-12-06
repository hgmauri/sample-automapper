using AutoMapper;
using Sample.Automapper.Application.Entities;
using Sample.Automapper.Application.ViewModels;

namespace Sample.Automapper.Application.Application;

public class ClientApplication : IClientApplication
{
    private readonly IMapper _mapper;

    public ClientApplication(IMapper mapper)
    {
        _mapper = mapper;
    }

    public async Task<ClientViewModel> AddClientAsync(ClientViewModel model)
    {
        var entity = _mapper.Map<Client>(model);

        //todo: call repository
        await Task.Delay(1);

        var result = _mapper.Map<ClientViewModel>(entity);

        return result;
    }

    public async Task<GroupViewModel> AddGroupAsync(GroupViewModel model)
    {
        var entity = _mapper.Map<Group>(model);

        //todo: call repository
        await Task.Delay(1);

        var result = _mapper.Map<GroupViewModel>(entity);

        return result;
    }
}