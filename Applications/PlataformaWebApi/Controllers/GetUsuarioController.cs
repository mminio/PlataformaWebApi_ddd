
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Usuarios.Application;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CRUD_UsuarioPFWEB.Controllers
{
    [ApiController]
    [Route("api/Usuario")]
    public class GetUsuarioController : Controller
    {
        
        private readonly IMediator mediator;
        public GetUsuarioController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [Route("{id}")]
        [HttpGet]
        [Authorize]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound)]

        public async Task<IActionResult> Get(int id)
        {
            var response = await mediator.Send(new GetUsuarioByIDQuery.Query(id));
           return response == null ? BadRequest("El id especificado no corresponde con ningún registro de usuario") : Ok(response);

        }

        /*
        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created, Type = typeof(DatosUsuario))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DatosUsuario))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(DatosUsuario))]
        public async Task<ActionResult<DatosUsuario>> Post([FromBody] DatosUsuario usuario)
        {
            var response = await mediator.Send(new AddUsuario.Command(usuario));
            return response == null ? Conflict("El usuario especificado no tiene el formato correcto") : Ok(usuario);
            //return response == null ? Conflict("El usuario especificado no tiene el formato correcto") : CreatedAtRoute("Get", new { usuario, usuario.Id }, new { result = "Done" } );
        }
        /*
        [Route("")]
        [HttpPut]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed, Type = typeof(DatosUsuario))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DatosUsuario))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DatosUsuario))]
        public async Task<ActionResult<DatosUsuario>> Put([FromBody]DatosUsuario usuario)
        {
            if (await orq.ReplaceUsuario(usuario))
            {
                return Ok(usuario);
            }
            else
            {
                return Conflict("Error al tratar de modificar el usuario");
            }
        }

        [Route("")]
        [HttpPatch]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed, Type = typeof(DatosUsuario))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(DatosUsuario))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DatosUsuario))]
        public async Task<ActionResult<DatosUsuario>> Patch([FromBody] DatosUsuario usuario)
        {
            if (await orq.ModifyUsuario(usuario))
            {
                return Ok(usuario);
            }
            else
            {
                return Conflict("Error al tratar de modificar el usuario");
            }
        }

        [Route("{id}")]
        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status405MethodNotAllowed, Type = typeof(int))]
        [ProducesResponseType(StatusCodes.Status200OK, Type = typeof(string))]
        [ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(string))]
        public async Task<ActionResult<DatosUsuario>> Delete(int id)
        {
            if (await orq.DeleteUsuario(id))
            {
                return Ok("Borrado exitoso");
            }
            else
            {
                return Conflict("Error al tratar de eliminar el usuario");
            }
        }
        */
    }
}
