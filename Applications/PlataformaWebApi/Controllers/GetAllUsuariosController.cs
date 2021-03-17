﻿using MediatR;
using Microsoft.AspNetCore.Http;
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
    public class GetAllUsuariosController : Controller
    {
        private readonly IMediator mediator;

        public GetAllUsuariosController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public async Task<IActionResult> Get()
        {
            var response = await mediator.Send(new GetAllUsuariosQuery.Query());
            return response == null ? Conflict("Error al intentar obtener los usuarios") : Ok(response);

        }
    }
}