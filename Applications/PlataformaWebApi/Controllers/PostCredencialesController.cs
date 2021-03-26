using MediatR;
using Microsoft.AspNetCore.Mvc;
using PlataformaWebApi.Credenciales.Application.DTOs;
using PlataformaWebApi.Credenciales.Application.Queries;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB.Controllers
{
    [ApiController]
    [Route("api/Login")]
    public class PostCredencialesController : Controller
    {
        private readonly IMediator mediator;
        public PostCredencialesController(IMediator mediator)
        {
            this.mediator = mediator;
        }


        [HttpPost]
        [Route("")]

        public async Task<ActionResult> Post([FromBody] CredencialesPostDTO cre)
        {
            var response = await mediator.Send(new LoginQuery.Query(cre._user, cre._password));
            return response == null ? Conflict("Los datos ingresados no son correctos") : Ok(response.token);
           
           
        }

    }
}
