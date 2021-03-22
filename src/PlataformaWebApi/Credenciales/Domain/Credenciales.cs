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
        public string _User { get; set; }
        [Required]
        public string _Password { get; set; }
    }
}
