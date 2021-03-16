using MediatR;
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
        private readonly IUsuarioRepository _usuarioRepository;
        public AddUsuarioCommandHandler(IUsuarioRepository ur)
        {
            this._usuarioRepository = ur;
        }
        public async Task<AddUsuarioCommand.Response> Handle(AddUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
            Usuarios.Domain.Usuario usuario = _usuarioRepository.AddUsuario(request.usuario);
            return usuario == null ? null : new Response(usuario);
        }
    }
}