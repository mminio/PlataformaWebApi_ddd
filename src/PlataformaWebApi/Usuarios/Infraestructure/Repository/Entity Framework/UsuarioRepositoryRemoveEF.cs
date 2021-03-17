using PlataformaWebApi.Shared.Repository;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Infraestructure.Repository.Entity_Framework
{
    public class UsuarioRepositoryRemoveEF : UsuarioRepositoryEF, IUsuarioRepositoryRemove
    {
        public UsuarioRepositoryRemoveEF(PlataformaWebApiContext context) : base(context)
        {

        }
        public void Remove(int id)
        {
            var usuario = this._context.Usuarios.Find(id);
            this._context.Usuarios.Remove(usuario);
            this._context.SaveChanges();
        }
    }
}
