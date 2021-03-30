using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.DTOs
{
    public class UsuarioPatchDTO 
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Email { get; set; }
        public short Edad { get; set; }
    }
}
