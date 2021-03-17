using MediatR;
using PlataformaWebApi.Usuarios.Application.Services;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PlataformaWebApi.Usuarios.Application.Queries.GetAllUsuariosQuery;

namespace PlataformaWebApi.Usuarios.Application.Queries.Handlers
{
    public class GetAllUsuariosQueryHandler : IRequestHandler<GetAllUsuariosQuery.Query, GetAllUsuariosQuery.Response>
    {
        private readonly UsuariosSearcher _searcher;
        public GetAllUsuariosQueryHandler(UsuariosSearcher searcher)
        {
            this._searcher = searcher;
        }
        public async Task<GetAllUsuariosQuery.Response> Handle(GetAllUsuariosQuery.Query request, CancellationToken cancellationToken)
        {
            List<Usuario> usuarios = _searcher.SearchAll();
            return usuarios == null ? null : new Response(usuarios);
        }
    }
}
