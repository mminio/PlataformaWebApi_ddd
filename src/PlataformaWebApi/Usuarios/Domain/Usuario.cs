using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace PlataformaWebApi.Usuarios.Domain
{
    public class Usuario
    {
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
