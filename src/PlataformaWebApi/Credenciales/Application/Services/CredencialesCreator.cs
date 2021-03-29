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
        private readonly ICredencialesRepositoryCreate _createRepository;
        private readonly ICredencialesRepositoryAuthenticate _authRepository;

        public CredencialesCreator(ICredencialesRepositoryCreate createRepository, ICredencialesRepositoryAuthenticate authRepository)
        {
            _createRepository = createRepository;
            _authRepository = authRepository;
        }

        internal string Create(UsuarioEmail usuarioEmail, CredencialPassword credencialPassword)
        {
            var credential = new Domain.Credenciales(){ _User = usuarioEmail };

            if (_authRepository.SearchByUser(credential) != null)
                return "Nombre de usuario no disponible";
            else
            {
                CredencialPassword encriptedPass = new CredencialPassword(CredencialesPasswordEncryptor.Encrypt(credencialPassword._Password));
                credential._Password = encriptedPass;
                _createRepository.Create(credential);

                return string.Empty;
            }            
        }
    }
}
