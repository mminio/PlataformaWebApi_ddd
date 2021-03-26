using PlataformaWebApi.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Infraestructure.Repository.Entity_Framework
{
    public class CredencialesRepositoryEF
    {
        public PlataformaWebApiContext _context { get; set; }

        public CredencialesRepositoryEF(PlataformaWebApiContext context)
        {
            this._context = context;
        }
    }
}
