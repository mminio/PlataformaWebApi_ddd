using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Queries
{
    public class ModifyUsuarioQuery
    {
        public record Query(int id, string nombre, string apellido, short edad, string email) : IRequest<Response>;
        public record Response(string result);
    }
}
