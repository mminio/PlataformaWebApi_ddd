using PlataformaWebApi.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Infraestructure.Repository
{
    public class UsuarioRepositoryEF
    {
        public PlataformaWebApiContext _context { get; set; }

        public UsuarioRepositoryEF(PlataformaWebApiContext context)
        {
            this._context = context;
        }
        
    }
}
