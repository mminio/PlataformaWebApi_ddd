using LoginApi.Common;
using LoginApi.Repository.Models;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class SvcSeguridad
    {
        public IConfiguration _config { get; set; }
        public SvcSeguridad(IConfiguration config)
        {
            _config = config;
            
        }

        public Credenciales AuthenticateUser(Credenciales cre)
        {
            Credenciales user = null;
            SvcCredenciales _service = new SvcCredenciales();

            var encryptedPass = Encrypter.Encrypt(cre._Password);
            Credenciales dbUser = _service.GetAccount(cre);

            if (dbUser._Password == encryptedPass)
            {
                user = new Credenciales { _User = dbUser._User, _Password = dbUser._Password };
            }
            return user;
        }

        public string GenerateJWT(Credenciales user)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, user._User),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()) // Para que no existan 2 tokens iguales
            };

            var token = new JwtSecurityToken(
              _config["Jwt:Issuer"], //Issuer   
              _config["Jwt:Issuer"], //Audience  
              claims,
              expires: System.DateTime.Now.AddMinutes(120), // Expira a las 2 horas, se puede modificar    
              signingCredentials: credentials);

            return new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

