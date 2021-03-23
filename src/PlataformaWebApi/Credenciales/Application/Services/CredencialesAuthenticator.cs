using PlataformaWebApi.Credenciales.Domain.Interfaces.Repository;
using PlataformaWebApi.Credenciales.Domain.Value_Objects;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Application.Services
{
    public class CredencialesAuthenticator
    {
        private readonly ICredencialesRepositoryAuthenticate _credencialesRepository;

        public CredencialesAuthenticator(ICredencialesRepositoryAuthenticate credencialesRepository)
        {
            _credencialesRepository = credencialesRepository;
        }

        public bool Authenticate(string user, string password)
        {
            UsuarioEmail email = new UsuarioEmail(user);
            CredencialPassword pass = new CredencialPassword(password);
             PlataformaWebApi.Credenciales.Domain.Credenciales cre = _credencialesRepository.SearchByUser( new PlataformaWebApi.Credenciales.Domain.Credenciales() { _User = email, _Password = pass });
            var encryptedPass = CredencialesPasswordEncryptor.Encrypt(password);

            if ( cre._Password._Password == encryptedPass)
            {
                return true;
            }
            else
            {
                return false;
            }

        }
    }
}
