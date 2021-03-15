using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PlataformaWebApi.Usuarios.Domain
{
    public class Usuario
    {
        #region Props

        [NotMapped]
        public UsuarioID ID { get; set; } 
        [NotMapped]
        public UsuarioNombre Nombre { get; set; }
        [NotMapped]
        public UsuarioApellido Apellido { get; set; }
        [NotMapped]
        public UsuarioEdad Edad { get; set; }
        [NotMapped]
        public UsuarioEmail Email { get; set; }
        #endregion

        #region Methods





        #endregion
        


    }
}
