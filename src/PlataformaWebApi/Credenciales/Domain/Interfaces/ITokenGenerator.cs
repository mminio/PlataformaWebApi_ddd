using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Domain.Interfaces
{
    public interface ITokenGenerator
    {
        string GenerateJWT(Credenciales credenciales);
    }
}
