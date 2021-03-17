using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Commands
{
    public class DeleteUsuarioCommand
    {
        public record Command (int id) : IRequest<Response>;
        public record Response (string result);
    }
}
