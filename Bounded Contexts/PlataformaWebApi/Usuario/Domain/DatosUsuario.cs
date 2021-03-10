using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace Common.Models
{
    [Table("DatosUsuario")]
    public partial class DatosUsuario
    {
        [Key]
        public int Id { get; set; }
        [StringLength(20)]
        public string Nombre { get; set; }
        [StringLength(20)]
        public string Apellido { get; set; }
        public short? Edad { get; set; }
        [StringLength(50)]
        public string Email { get; set; }
    }
}
