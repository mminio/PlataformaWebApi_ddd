using MediatR;
using System.Collections.Generic;

namespace PlataformaWebApi.Usuarios.Application.Commands
{
    public class ModifyUsuarioCommand
    {
        public record Command(int id, IDictionary<string, object> operations) : IRequest<Response>;
        public record Response(string result);
    }
}
