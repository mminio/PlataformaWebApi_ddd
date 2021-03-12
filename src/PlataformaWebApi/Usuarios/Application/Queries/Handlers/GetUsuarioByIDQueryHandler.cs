using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Queries.Handlers
{
    public class GetUsuarioByIDQueryHandler : IRequestHandler<GetUsuarioByIDQuery.Query, GetUsuarioByIDQuery.Response>
    {
        private readonly UsuarioContext _usuarioRepository;
        public Handler(UsuarioContext ur)
        {
            this._usuarioRepository = ur;
        }
        public Task<GetUsuarioByIDQuery.Response> Handle(GetUsuarioByIDQuery.Query request, CancellationToken cancellationToken)
        {
            Usuarios.Domain.Usuario usuario = _usuarioRepository.usuarios.FirstOrDefault(x => x.Id == request.id);
            return usuario == null ? null : new Response(usuario);
        }
    }
}
