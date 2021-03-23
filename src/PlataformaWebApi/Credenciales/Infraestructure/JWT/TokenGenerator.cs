using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using PlataformaWebApi.Credenciales.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Infraestructure.JWT
{
    public class TokenGenerator : ITokenGenerator
    {
        public IConfiguration _config { get; set; }
        public TokenGenerator(IConfiguration config)
        {
            _config = config;

        }
        public string GenerateJWT(Credenciales.Domain.Credenciales credenciales)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            var claims = new[] {
                new Claim(JwtRegisteredClaimNames.Sub, credenciales._User.Email),
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
