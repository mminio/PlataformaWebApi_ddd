using PlataformaWebApi.Credenciales.Domain.Interfaces.Repository;
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
             PlataformaWebApi.Credenciales.Domain.Credenciales cre = _credencialesRepository.SearchByUser( new PlataformaWebApi.Credenciales.Domain.Credenciales() { _User = user, _Password = password });


        }
    }
}
