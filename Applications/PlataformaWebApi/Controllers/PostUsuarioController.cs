using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Usuarios.Application;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB.Controllers
{
    [ApiController]
    [Route("[[Usuario]]")]
    public class PostUsuarioController : Controller
    {
        private readonly IMediator mediator;
        public PostUsuarioController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost]
        //[ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Usuario))]
        //[ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DatosUsuario))]
        //[ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(DatosUsuario))]
        public async Task<ActionResult> Post(string nombre, string apellido, short edad, string email)
        {
            var response = await mediator.Send(new AddUsuarioCommand.Command(nombre, apellido, edad, email));
            return response == null ? Conflict("El usuario especificado no tiene el formato correcto") : Ok();
            //return response == null ? Conflict("El usuario especificado no tiene el formato correcto") : CreatedAtRoute("Get", new { usuario, usuario.Id }, new { result = "Done" } );
        }
    }
}