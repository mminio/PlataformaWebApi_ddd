using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.JsonPatch;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Usuarios.Application.Commands;
using PlataformaWebApi.Usuarios.Application.DTOs;
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
        [Route("{id}")]
        #if !DEBUG
        [Authorize]
        #endif
        public async Task<IActionResult> Patch(int id, [FromBody] JsonPatchDocument<UsuarioPatchDTO> patch)
        {
            var response = await mediator.Send(new ModifyUsuarioCommand.Command(id, patch.Operations.ToDictionary(r => r.path, r => r.value)));
            return response == null ? Conflict("Se produjo un error al modificar el usuario") : Ok(response.result);
        }


    }
}
