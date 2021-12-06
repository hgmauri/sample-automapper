using Microsoft.AspNetCore.Mvc;
using Sample.Automapper.Application.Application;
using Sample.Automapper.Application.ViewModels;

namespace Sample.Automapper.WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientController : ControllerBase
{
    private readonly IClientApplication _clientApplication;

    public ClientController(IClientApplication clientApplication)
    {
        _clientApplication = clientApplication;
    }

    [HttpPost]
    public async Task<IActionResult> PostClient([FromBody] ClientViewModel model)
    {
        var validation = await _clientApplication.AddClientAsync(model);

        return Ok(validation);
    }

    [HttpPost("group")]
    public async Task<IActionResult> PostGroup([FromBody] GroupViewModel model)
    {
        var validation = await _clientApplication.AddGroupAsync(model);

        return Ok(validation);
    }
}
