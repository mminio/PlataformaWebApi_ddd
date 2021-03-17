using AutoMapper;
using MediatR;
using PlataformaWebApi.Usuarios.Application.Interfaces.DTOs;
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

        public ModifyUsuarioCommandHandler(UsuarioModifier modifier)
        {
            _modifier = modifier;
        }

        public async Task<ModifyUsuarioCommand.Response> Handle(ModifyUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
            //        CreateMap<ProfilePartialUpdate, UserProfile>()
            //.ForMember(dest => dest.Avatar, opt => opt.Condition(src => src.Avatar != default(int)))
            //.ForMember(dest => dest.Avatar, opt => opt.MapFrom(src => src.Avatar))
            //.ForMember(dest => dest.Username, opt => opt.Condition(src => src.Nickname != default(string)))
            //.ForMember(dest => dest.Username, opt => opt.MapFrom(src => src.Nickname))
            //.ForMember(dest => dest.UserId, opt => opt.Ignore());

            //_modifier.Modify(
            //    request.id,
            //    new UsuarioNombre(request.nombre),
            //    new UsuarioApellido(request.apellido),
            //    new UsuarioEdad(request.edad),
            //    new UsuarioEmail(request.email));

            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<Usuario, IUsuarioPartialUpdateDTO>();
            });

            


            //return new Response("Usuario modificado con éxito");
        }
    }
}
