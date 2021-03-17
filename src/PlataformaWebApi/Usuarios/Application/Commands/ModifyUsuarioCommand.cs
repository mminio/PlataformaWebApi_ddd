using MediatR;
using Microsoft.AspNetCore.JsonPatch;
using PlataformaWebApi.Usuarios.Application.Interfaces.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Commands
{
    public class ModifyUsuarioCommand
    {
        public record Command(int id, JsonPatchDocument<IUsuarioPartialUpdateDTO> usuarioJsonPatchDocument) : IRequest<Response>;
        // public record Query(int id, string nombre, string apellido, short edad, string email) : IRequest<Response>;
        public record Response(string result);
    }
}
