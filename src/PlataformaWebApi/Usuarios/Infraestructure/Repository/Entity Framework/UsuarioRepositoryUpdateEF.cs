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
    public class UsuarioRepositoryUpdateEF : UsuarioRepositoryEF, IUsuarioRepositoryUpdate
    {
        public UsuarioRepositoryUpdateEF(PlataformaWebApiContext context) : base(context)
        {
        }

        public void Update(Usuario usuario)
        {
            this._context.Usuarios.Update(usuario);
            this._context.SaveChanges();

        }
    }
}
