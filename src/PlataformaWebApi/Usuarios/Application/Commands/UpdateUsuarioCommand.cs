using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Commands
{
    public class UpdateUsuarioCommand
    {
        public record Command(string nombre, string apellido, short edad, string email, int id) : IRequest<Response>;
        public record Response(string result);

    }
}
