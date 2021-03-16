using MediatR;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaWebApi.Usuarios.Application
{
    public class CreateUsuarioCommand
    {
        public record Command(string nombre, string apellido, short edad, string email) : IRequest<Response>;
        public record Response(string result);
    }
}