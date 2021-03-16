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
    public class UsuarioRepositorySearchByIdEF : UsuarioRepositoryEF, IUsuarioRepositorySearchById
    {     
        public UsuarioRepositorySearchByIdEF(PlataformaWebApiContext context) : base(context)
        {
        }

        public Usuario SearchById(int id)
        {
            return this._context.Usuarios.FirstOrDefault(e => e.Id == id);
        }
    }
}
