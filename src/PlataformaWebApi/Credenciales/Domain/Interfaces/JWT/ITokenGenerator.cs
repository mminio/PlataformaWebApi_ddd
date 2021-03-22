using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Domain.Interfaces.JWT
{
    public interface ITokenGenerator
    {
        public string GenerateJWT(Credenciales credenciales);
    }
}
