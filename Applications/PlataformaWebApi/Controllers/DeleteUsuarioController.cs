using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Usuarios.Application.Commands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB.Controllers
{
    [ApiController]
    [Route("api/Usuario")]
    public class DeleteUsuarioController : Controller
    {
        private readonly IMediator mediator;
        public DeleteUsuarioController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        
        [HttpDelete]
        [Route("{id}")]
        #if !DEBUG
        [Authorize]
        #endif
        public async Task<IActionResult> Delete(int id)
        {
            var response = await mediator.Send(new DeleteUsuarioCommand.Command(id));
            return response == null ? BadRequest("El id especificado no corresponde con ningún registro de usuario") : Ok(response);

        }

    }
}
