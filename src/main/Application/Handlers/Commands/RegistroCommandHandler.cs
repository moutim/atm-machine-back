using Application.Commands;
using Domain.Models;
using Domain.Models.Responses;
using MediatR;

namespace Application.Handlers.Commands;

public class RegistroCommandHandler : IRequestHandler<RegistroCommand, RegistroResponse>
{
    public Task<RegistroResponse> Handle(RegistroCommand request, CancellationToken cancellationToken)
    {
        var response = new RegistroResponse()
        {
            Resultado = "Teste"
        };

        return Task.FromResult(response);
    }
}