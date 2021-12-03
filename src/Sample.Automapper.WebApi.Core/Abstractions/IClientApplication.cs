using Sample.Automapper.WebApi.Core.ViewModels;

namespace Sample.Automapper.WebApi.Core.Abstractions;

public interface IClientApplication
{
    Task<ClientViewModel> AddClient(ClientViewModel model);
}
