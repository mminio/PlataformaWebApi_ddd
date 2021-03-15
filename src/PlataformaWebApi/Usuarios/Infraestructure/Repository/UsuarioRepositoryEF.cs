using PlataformaWebApi.Shared.Repository;
using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Infraestructure.Repository
{
    public class UsuarioRepositoryEF : IUsuarioRepository
    {
        public PlataformaWebApiContext _context { get; set; }

        public UsuarioRepositoryEF(PlataformaWebApiContext context)
        {
            this._context = context;
        }

        public Usuario GetUsuarioById(int id)
        {
            return this._context.Usuarios.Find(id);
        }

        public void AddUsuario(Usuario usuario)
        {
            this._context.Usuarios.Add(usuario);
        }
    }
}
