using MediatR;
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
        public LoginQueryHandler(CredencialesAuthenticator auth)
        {
            this._authenticator = auth;
        }
        public async Task<LoginQuery.Response> Handle(LoginQuery.Query request, CancellationToken cancellationToken)
        {
           
        }
    }
}
