using MediatR;
using PlataformaWebApi.Usuarios.Application.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PlataformaWebApi.Usuarios.Application.Commands.DeleteUsuarioCommand;

namespace PlataformaWebApi.Usuarios.Application.Commands.Handlers
{
     public class DeleteUsuarioCommandHandler : IRequestHandler<DeleteUsuarioCommand.Command, DeleteUsuarioCommand.Response>
    {
        public DeleteUsuarioCommandHandler(UsuarioRemover remover)
        {
            this.remover = remover;
        }

        private UsuarioRemover remover { get; set; }


        public async Task<DeleteUsuarioCommand.Response> Handle(DeleteUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
            remover.Remove(request.id);
            
            return new Response("Usuario eliminado con éxito");
        }
    }
}
