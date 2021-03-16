using System;
using System.Collections.Generic;
using System.Text;

namespace PlataformaWebApi.Usuarios.Domain
{
    public class Usuario
    {
        public Usuario(UsuarioNombre nombre, UsuarioApellido apellido, UsuarioEdad edad, UsuarioEmail email)
        {
            Nombre = nombre;
            Apellido = apellido;
            Edad = edad;
            Email = email;
        }

        public Usuario()
        {

        }
        #region Props        

        public int Id { get; set; }
        public UsuarioNombre Nombre { get; set; }
        public UsuarioApellido Apellido { get; set; }
        public UsuarioEdad Edad { get; set; }
        public UsuarioEmail Email { get; set; }
        #endregion

        #region Methods

        #endregion
        


    }
}
