using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Services
{
    public class UsuarioSearcherByID
    {
        private readonly IUsuarioRepositorySearchById _usuarioRepository;

        public UsuarioSearcherByID(IUsuarioRepositorySearchById usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public Usuario SearchByID(int id)
        {
            return _usuarioRepository.SearchById(id);
        }
    }
}
