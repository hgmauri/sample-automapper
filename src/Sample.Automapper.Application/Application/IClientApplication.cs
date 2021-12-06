using Sample.Automapper.Application.ViewModels;

namespace Sample.Automapper.Application.Application;

public interface IClientApplication
{
    Task<ClientViewModel> AddClientAsync(ClientViewModel model);
    Task<GroupViewModel> AddGroupAsync(GroupViewModel model);
}
