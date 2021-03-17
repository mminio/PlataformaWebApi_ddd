using MediatR;
using PlataformaWebApi.Usuarios.Application.Services;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static PlataformaWebApi.Usuarios.Application.Queries.ModifyUsuarioQuery;

namespace PlataformaWebApi.Usuarios.Application.Queries.Handlers
{
    public class ModifyUsuarioQueryHandler : IRequestHandler<ModifyUsuarioQuery.Query, ModifyUsuarioQuery.Response>
    {
        private readonly UsuarioModifier _modifier;

        public ModifyUsuarioQueryHandler(UsuarioModifier modifier)
        {
            _modifier = modifier;
        }

        public async Task<ModifyUsuarioQuery.Response> Handle(ModifyUsuarioQuery.Query request, CancellationToken cancellationToken)
        {
            _modifier.Modify(
                request.id,
                new UsuarioNombre(request.nombre),
                new UsuarioApellido(request.apellido),
                new UsuarioEdad(request.edad),
                new UsuarioEmail(request.email));

            return new Response("Usuario modificado con éxito");
        }
    }
}
