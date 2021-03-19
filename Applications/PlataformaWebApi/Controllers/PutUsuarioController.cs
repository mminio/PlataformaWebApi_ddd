
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Usuarios.Application.Commands;
using PlataformaWebApi.Usuarios.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB.Controllers
{
        [ApiController]
        [Route("api/Usuario")]
        public class PutUsuarioController : Controller
        {
            private readonly IMediator mediator;
            public PutUsuarioController(IMediator mediator)
            {
                this.mediator = mediator;
            }

            [HttpPut]
            [Route("{id}")]
            //[ProducesResponseType(StatusCodes.Status201Created, Type = typeof(Usuario))]
            //[ProducesResponseType(StatusCodes.Status404NotFound, Type = typeof(DatosUsuario))]
            //[ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(DatosUsuario))]
            public async Task<ActionResult> Put([FromBody] UsuarioPutDTO usuario, int id)
            {
                var response = await mediator.Send(new UpdateUsuarioCommand.Command(usuario.nombre, usuario.apellido, usuario.edad, usuario.email, id));
                return response == null ? Conflict("El usuario especificado no tiene el formato correcto") : Ok(response.result);
                //return response == null ? Conflict("El usuario especificado no tiene el formato correcto") : CreatedAtRoute("Get", new { usuario, usuario.Id }, new { result = "Done" } );
            }
        }
    }
