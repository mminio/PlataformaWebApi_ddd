using CRUD_UsuarioPFWEB.DTOs;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Usuarios.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB.Controllers
{
    [ApiController]
    [Route("[[Usuario]]")]
    public class PatchUsuarioController : Controller
    {
        private readonly IMediator mediator;

        public PatchUsuarioController(IMediator mediator)
        {
            this.mediator = mediator;
        }
        
        [HttpPatch]
        public async Task<IActionResult> Patch([FromBody] UsuarioDTO usuario)
        {
            var response = await mediator.Send(new ModifyUsuarioQuery.Query(usuario.id, usuario.nombre, usuario.apellido, usuario.edad, usuario.email));
            return response == null ? Conflict("Se produjo un error al modificar el usuario") : Ok(response.result);
        }
    }
}
