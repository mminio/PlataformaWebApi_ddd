using PlataformaWebApi.Shared.Repository;
using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Infraestructure.Repository.Entity_Framework
{
    public class UsuarioRepositoryCreateEF : UsuarioRepositoryEF, IUsuarioRepositoryCreate
    {        
        public UsuarioRepositoryCreateEF(PlataformaWebApiContext context) : base(context)
        {
        }

        public Usuario Create(Usuario usuario)
        {
            this._context.Usuarios.Add(usuario);
            this._context.SaveChanges();
            return usuario;
        }
    }
}
