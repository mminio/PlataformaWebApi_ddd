using System;

namespace UsuarioDomain
{
    public class Usuario
    {
        public UsuarioID ID { get; set; }
        public UsuarioNombre Nombre { get; set; }
        public UsuarioApellido  Apellido { get; set; }
        public UsuarioEmail Email { get; set; }
        public UsuarioEdad Edad { get; set; }
    }
}
