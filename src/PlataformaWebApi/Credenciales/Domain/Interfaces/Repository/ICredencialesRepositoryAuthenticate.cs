using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Domain.Interfaces.Repository
{
    public interface ICredencialesRepositoryAuthenticate
    {
        Credenciales SearchByUser(Credenciales cre);

    }
}
