using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Domain.Value_Objects
{
    public class CredencialPassword
    {
        public string Password { get; }
        public CredencialPassword(string pass)
        {
            // validaciones 
            Password = pass;

        }
    }
}
