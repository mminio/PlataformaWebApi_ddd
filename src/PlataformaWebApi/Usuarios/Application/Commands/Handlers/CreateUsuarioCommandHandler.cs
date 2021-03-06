using MediatR;
using PlataformaWebApi.Credenciales.Application.Services;
using PlataformaWebApi.Credenciales.Domain.Value_Objects;
using PlataformaWebApi.Usuarios.Application.Services;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PlataformaWebApi.Usuarios.Application.CreateUsuarioCommand;

namespace PlataformaWebApi.Usuarios.Application.Commands.Handlers
{
    public class CreateUsuarioCommandHandler : IRequestHandler<CreateUsuarioCommand.Command, CreateUsuarioCommand.Response>
    {
        public CreateUsuarioCommandHandler(UsuarioCreator creator, CredencialesCreator creCreator)
        {
            this.creator = creator;
            this._creCreator = creCreator;
        }

        private UsuarioCreator creator { get; set; }
        private CredencialesCreator _creCreator { get; set; }

        public async Task<CreateUsuarioCommand.Response> Handle(CreateUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
            var credentialErrorMsg = _creCreator.Create(
                new CredencialUsername(request.username),
                new CredencialPassword(request.password));

            if (!string.IsNullOrEmpty(credentialErrorMsg))
                return new Response(credentialErrorMsg);

            else
            {
                creator.Create(
                    new UsuarioNombre(request.nombre),
                    new UsuarioApellido(request.apellido),
                    new UsuarioEdad(request.edad),
                    new UsuarioEmail(request.email)
                );

                return new Response("Usuario creado con éxito");
            }                
        }
    }
}