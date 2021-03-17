using PlataformaWebApi.Usuarios.Application.Interfaces.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_UsuarioPFWEB.DTOs.Usuario
{
    public class UsuarioPatchDTO : IUsuarioPartialUpdateDTO
    {
        public string nombre { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string apellido { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public string email { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
        public short edad { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    }
}
