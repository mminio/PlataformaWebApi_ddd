using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Services
{
    public class UsuarioCreator
    {
        private readonly IUsuarioRepositoryCreate _usuarioRepository;

        public UsuarioCreator(IUsuarioRepositoryCreate usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Create(Usuario usuario)
        {
            _usuarioRepository.Create(usuario);
        }
    }
}
