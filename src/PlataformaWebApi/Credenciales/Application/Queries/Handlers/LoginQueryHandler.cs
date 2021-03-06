using MediatR;
using PlataformaWebApi.Credenciales.Application.Services;
using PlataformaWebApi.Credenciales.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Application.Queries.Handlers
{
    public class LoginQueryHandler : IRequestHandler<LoginQuery.Query, LoginQuery.Response>
    {
        private readonly CredencialesAuthenticator _authenticator;
        private readonly ITokenGenerator _tokenGenerator;
        public LoginQueryHandler(CredencialesAuthenticator auth, ITokenGenerator tokenGen)
        {
            this._authenticator = auth;
            this._tokenGenerator = tokenGen;
        }

        public LoginQueryHandler(CredencialesAuthenticator auth)
        {
            this._authenticator = auth;
            
        }
        public async Task<LoginQuery.Response> Handle(LoginQuery.Query request, CancellationToken cancellationToken)
        {
            if (_authenticator.Authenticate(request.user, request.password))
            {
                return new LoginQuery.Response(_tokenGenerator.GenerateJWT(new Domain.Credenciales()
                {
                    _User = new Domain.Value_Objects.CredencialUsername(request.user),
                    _Password = new Domain.Value_Objects.CredencialPassword(request.password)
                }));
            }
            else
            {
                return new LoginQuery.Response(String.Empty);
            }

            

        }
    }
}
