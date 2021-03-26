using PlataformaWebApi.Credenciales.Domain.Interfaces.Repository;
using PlataformaWebApi.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Infraestructure.Repository.Entity_Framework
{
    public class CredencialesRepositoryCreateEF : CredencialesRepositoryEF ,  ICredencialesRepositoryCreate
    {
        public CredencialesRepositoryCreateEF(PlataformaWebApiContext context) : base(context)
        {
        }

        public void Create(Credenciales.Domain.Credenciales credenciales)
        {
            this._context.Credenciales.Add(credenciales);
            this._context.SaveChanges();
        }
    }
}
