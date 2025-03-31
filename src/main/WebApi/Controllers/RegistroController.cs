using Application.Commands;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace WebApi.Controllers;

[ApiController]
[Route("[controller]")]
public class RegistroController : ControllerBase
{
    private readonly IMediator _mediator;

    public RegistroController(IMediator mediator)
    {
        _mediator = mediator;
    }
    
    [HttpPost(Name = "Registro")]
    public async Task<IActionResult> Registrar([FromBody] RegistroCommand command)
    {
        var result = await _mediator.Send(command);
        return Ok(result);
    }
}