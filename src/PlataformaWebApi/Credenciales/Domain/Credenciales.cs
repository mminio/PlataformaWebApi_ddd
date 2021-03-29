using PlataformaWebApi.Credenciales.Domain.Value_Objects;
using PlataformaWebApi.Usuarios.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Domain
{
    public class Credenciales
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public CredencialUsername _User { get; set; }
        [Required]
        public CredencialPassword _Password { get; set; }
    }
}
