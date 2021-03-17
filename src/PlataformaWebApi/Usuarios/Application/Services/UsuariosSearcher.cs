using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Services
{
    public class UsuariosSearcher
    {
        private readonly IUsuarioRepositorySearchAll _usuarioRepository;

        public UsuariosSearcher(IUsuarioRepositorySearchAll usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public List<Usuario> SearchAll()
        {
            return _usuarioRepository.SearchAll();
        }
    }
}
