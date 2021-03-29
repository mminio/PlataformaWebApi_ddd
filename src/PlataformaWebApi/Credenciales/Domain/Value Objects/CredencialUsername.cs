using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Domain.Value_Objects
{
    public class CredencialUsername
    {
        public string _Username { get; }
        public CredencialUsername(string username)
        {
            _Username = username;
        }
    }
}
