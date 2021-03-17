using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Services
{
    public class UsuarioRemover
    {
        private readonly IUsuarioRepositoryRemove _usuarioRepository;

        public UsuarioRemover(IUsuarioRepositoryRemove usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }

        public void Remove(int id)
        {
            _usuarioRepository.Remove(id);
        }
    }
}
