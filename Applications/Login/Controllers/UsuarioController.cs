using Common.Models;
using Domain.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LoginApi.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class UsuarioController : Controller
    {
        public SvcOrquestador orq { get; set; }
        public UsuarioController(SvcOrquestador o)
        {
            this.orq = o;
        }

        [Route("{id?}")]
        [HttpGet]
        public List<DatosUsuario> Get(string? id )
        {
            return orq.GetUsuarios(id);
        }

        [Route("")]
        [HttpPost]
        public async Task<ActionResult> Post([FromBody] DatosUsuario usuario)
        {
            if ( await orq.CreateUsuario(usuario))
            {
                return Json(usuario);
            }
            else
            {
                return Json("Error al tratar de crear el usuario");
            }
        }

        [Route("")]
        [HttpPut]
        public async Task<ActionResult> Put([FromBody]DatosUsuario usuario)
        {
            if (await orq.ReplaceUsuario(usuario))
            {
                return Json(usuario);
            }
            else
            {
                return Json("Error al tratar de crear el usuario");
            }
        }
    }
}
