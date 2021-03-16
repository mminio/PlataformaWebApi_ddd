using MediatR;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PlataformaWebApi.Usuarios.Application.GetUsuarioByIDQuery;

namespace PlataformaWebApi.Usuarios.Application.Queries.Handlers
{
    public class GetUsuarioByIDQueryHandler : IRequestHandler<GetUsuarioByIDQuery.Query, GetUsuarioByIDQuery.Response>
    {
        private readonly IUsuarioRepositorySearchById _usuarioRepository;
        public GetUsuarioByIDQueryHandler(IUsuarioRepositorySearchById ur)
        {
            this._usuarioRepository = ur;
        }
        public async Task<GetUsuarioByIDQuery.Response> Handle(GetUsuarioByIDQuery.Query request, CancellationToken cancellationToken)
        {
            Usuarios.Domain.Usuario usuario = _usuarioRepository.SearchById(request.id);
            return usuario == null ? null : new Response(usuario);
        }
    }
}
