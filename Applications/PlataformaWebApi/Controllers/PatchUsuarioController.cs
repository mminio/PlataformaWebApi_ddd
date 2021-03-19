
using MediatR;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Usuarios.Application.Commands;
using PlataformaWebApi.Usuarios.Application.DTOs;

using PlataformaWebApi.Usuarios.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB.Controllers
{
    [ApiController]
    [Route("api/Usuario")]
    public class PatchUsuarioController : Controller
    {
        private readonly IMediator mediator;

        public PatchUsuarioController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPatch]
        //public async Task<IActionResult> Patch([FromBody] UsuarioPatchDTO usuario)
        //{
        //    var response = await mediator.Send(new ModifyUsuarioQuery.Query(usuario.id, usuario.nombre, usuario.apellido, usuario.edad, usuario.email));
        //    return response == null ? Conflict("Se produjo un error al modificar el usuario") : Ok(response.result);
        //}

        [HttpPatch]
        [Route("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] JsonPatchDocument<UsuarioPatchDTO> usuarioJsonPatchDocument)
        {
            var response = await mediator.Send(new ModifyUsuarioCommand.Command(id, usuarioJsonPatchDocument));
            //CreateMap<JsonPatchDocument<UsuarioPutDTO>, JsonPatchDocument<UserProfile>>();
            //CreateMap<Operation<ProfileUpdate>, Operation<UserProfile>>();
            await Task.CompletedTask;
            return NoContent();
        }


    }
}
