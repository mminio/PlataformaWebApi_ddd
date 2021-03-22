using PlataformaWebApi.Credenciales.Domain.Interfaces.Repository;
using PlataformaWebApi.Shared.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Infraestructure.Repository.Entity_Framework
{
    public class CredencialesRepositoryAuthenticateEF : CredencialesRepositoryEF, ICredencialesRepositoryAuthenticate
    {
        public CredencialesRepositoryAuthenticateEF(PlataformaWebApiContext context) : base(context)
        {
        }

        public Domain.Credenciales SearchByUser(Domain.Credenciales cre)
        {
            return this._context.Credenciales.FirstOrDefault(e => e._User == cre._User);

        }

        


    }
}
