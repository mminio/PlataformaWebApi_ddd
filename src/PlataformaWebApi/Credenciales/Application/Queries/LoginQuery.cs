using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Application.Queries
{
    public class LoginQuery
    {
        public record Query (string user, string password) : IRequest<Response>;
        public record Response (string token); 
    }
}
