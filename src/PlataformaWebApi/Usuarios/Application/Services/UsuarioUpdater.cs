using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Services
{
    public class UsuarioUpdater
    {
        private readonly IUsuarioRepositoryUpdate _usuarioRepository;

        public UsuarioUpdater(IUsuarioRepositoryUpdate usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Update(int id, UsuarioNombre nombre, UsuarioApellido apellido, UsuarioEdad edad, UsuarioEmail email)
        {
            Usuario usuario = new Usuario(nombre, apellido, edad, email);
            usuario.Id = id;
            _usuarioRepository.Update(usuario);
        }
    }
}
