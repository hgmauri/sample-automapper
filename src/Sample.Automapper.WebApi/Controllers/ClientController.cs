using Microsoft.AspNetCore.Mvc;
using Sample.Automapper.WebApi.Core.Abstractions;
using Sample.Automapper.WebApi.Core.ViewModels;

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
    public async Task<IActionResult> Post([FromBody] ClientViewModel model)
    {
        var validation = await _clientApplication.AddClient(model);

        return Ok(validation);
    }
}
