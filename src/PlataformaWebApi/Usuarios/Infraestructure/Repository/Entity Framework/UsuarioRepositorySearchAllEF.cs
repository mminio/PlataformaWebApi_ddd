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
    public class UsuarioRepositorySearchAllEF : UsuarioRepositoryEF, IUsuarioRepositorySearchAll
    {
        public UsuarioRepositorySearchAllEF(PlataformaWebApiContext context) : base(context)
        {
        }

        public List<Usuario> SearchAll()
        {
            return this._context.Usuarios.ToList();
        }
    }
}
