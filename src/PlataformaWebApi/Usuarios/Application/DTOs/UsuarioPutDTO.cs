using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.DTOs
{
    public class UsuarioPutDTO
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string email { get; set; }
        public short edad { get; set; }
    }
}
