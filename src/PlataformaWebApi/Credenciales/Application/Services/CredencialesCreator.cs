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
    public class CredencialesCreator
    {
        private readonly ICredencialesRepositoryCreate _credencialesRepository;

        public CredencialesCreator(ICredencialesRepositoryCreate credencialesRepository)
        {
            _credencialesRepository = credencialesRepository;
        }

        internal void Create(UsuarioEmail usuarioEmail, CredencialPassword credencialPassword)
        {

            CredencialPassword encriptedPass = new CredencialPassword(CredencialesPasswordEncryptor.Encrypt(credencialPassword._Password));
            _credencialesRepository.Create(new Domain.Credenciales()
            {
                _User = usuarioEmail,
                _Password = encriptedPass
            });
        }
    }
}
