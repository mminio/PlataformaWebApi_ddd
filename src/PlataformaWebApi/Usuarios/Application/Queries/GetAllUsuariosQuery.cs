using MediatR;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Queries
{
    public class GetAllUsuariosQuery
    {
        public record Query() : IRequest<Response>;
        public record Response(List<Usuario> usuarios);
    }
}
