using MediatR;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaWebApi.Usuarios.Application
{
    public class AddUsuarioCommand
    {
        public record Command(Usuario usuario) : IRequest<Response>;
        public record Response(Usuario usuario);
    }
}