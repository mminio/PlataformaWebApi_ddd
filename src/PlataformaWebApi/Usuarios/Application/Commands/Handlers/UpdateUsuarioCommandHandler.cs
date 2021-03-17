using MediatR;
using PlataformaWebApi.Usuarios.Application.Services;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PlataformaWebApi.Usuarios.Application.Commands.UpdateUsuarioCommand;

namespace PlataformaWebApi.Usuarios.Application.Commands.Handlers
{
    public class UpdateUsuarioCommandHandler : IRequestHandler<UpdateUsuarioCommand.Command, UpdateUsuarioCommand.Response>
    {
        public UpdateUsuarioCommandHandler(UsuarioUpdater updater)
        {
            this.updater = updater;
        }

        private UsuarioUpdater updater { get; set; }


        public async Task<UpdateUsuarioCommand.Response> Handle(UpdateUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
            updater.Update(
                request.id,
                new UsuarioNombre(request.nombre),
                new UsuarioApellido(request.apellido),
                new UsuarioEdad(request.edad),
                new UsuarioEmail(request.email)
            );
            return new Response("Usuario actualizado con éxito");
        }
    }
}
