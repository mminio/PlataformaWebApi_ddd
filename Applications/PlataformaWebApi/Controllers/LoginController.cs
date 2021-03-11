
using Domain.Services;
using LoginApi.Common;
using LoginApi.Repository;
using LoginApi.Repository.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LoginController : ControllerBase
    {
        public SvcOrquestador orq { get; set; }
        public LoginController(SvcOrquestador o)
        {
            this.orq = o;
        }

        [AllowAnonymous]
        [HttpPost]
        [Route("")]
        public ActionResult Acceso([FromBody] Credenciales cre)
        {
           
            string tokenString = orq.AutorizarAcceso(cre);
            if (String.IsNullOrEmpty(tokenString))
            {
                return Unauthorized();
            }
            else
            {
                return Ok(new { token = tokenString });
            }
            
        }

        //[HttpPost]
        //[Route("AltaUsuario")]
        //public async Task<Credenciales> AltaUsuario([FromBody] Credenciales cre)
        //{

            
        //    cre._Password = Encrypter.Encrypt(cre._Password);
        //    _context.Add(cre);
        //    await _context.SaveChangesAsync();
        //    return cre;
           
        //}


      
    }
}
