using MediatR;
using PlataformaWebApi.Usuarios.Application.Services;
using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PlataformaWebApi.Usuarios.Application.AddUsuarioCommand;

namespace PlataformaWebApi.Usuarios.Application.Commands.Handlers
{
    public class AddUsuarioCommandHandler : IRequestHandler<AddUsuarioCommand.Command, AddUsuarioCommand.Response>
    {
        public AddUsuarioCommandHandler(UsuarioCreator creator)
        {
            this.creator = creator;
        }

        private UsuarioCreator creator { get; set; }
        

        public async Task<AddUsuarioCommand.Response> Handle(AddUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
            var usuario = new Usuario(
                new UsuarioNombre(request.nombre), 
                new UsuarioApellido(request.apellido), 
                new UsuarioEdad(request.edad), 
                new UsuarioEmail(request.email)
                );

            creator.Create(usuario);
            return new Response("Usuario creado con éxito");
        }
    }
}