using AutoMapper;
using MediatR;
using PlataformaWebApi.Usuarios.Application.DTOs;
using PlataformaWebApi.Usuarios.Application.Services;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;


namespace PlataformaWebApi.Usuarios.Application.Commands.Handlers
{
    public class ModifyUsuarioCommandHandler : IRequestHandler<ModifyUsuarioCommand.Command, ModifyUsuarioCommand.Response>
    {
        private readonly UsuarioModifier _modifier;
        private readonly UsuarioSearcherByID _searcherByID;

        public ModifyUsuarioCommandHandler(UsuarioModifier modifier, UsuarioSearcherByID searcher)
        {
            _modifier = modifier;
            _searcherByID = searcher;
        }

        public async Task<ModifyUsuarioCommand.Response> Handle(ModifyUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
           
            return new ModifyUsuarioCommand.Response("Usuario modificado con éxito");
        }
    }
}
