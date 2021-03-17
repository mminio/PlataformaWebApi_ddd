using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Services
{
    public class UsuarioModifier
    {
        private readonly IUsuarioRepositoryModify _usuarioRepository;

        public UsuarioModifier(IUsuarioRepositoryModify usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Modify(int id, UsuarioNombre nombre, UsuarioApellido apellido, UsuarioEdad edad, UsuarioEmail email)
        {
            Usuario usuario = new Usuario(nombre, apellido, edad, email);
            usuario.Id = id;
            _usuarioRepository.Modify(usuario);
        }
    }
}
