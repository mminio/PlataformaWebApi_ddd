using MediatR;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.Text;


namespace PlataformaWebApi.Usuarios.Application
{
    public class GetUsuarioByIDQuery
    {
        public record Query (int id) : IRequest<Response>;
        public record Response (Usuario usuario);

        

    }
}
