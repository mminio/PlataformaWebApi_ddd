using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace LoginApi.Repository.Models
{
    public partial class Credenciales
    {
        [Key]
        
        public int Id { get; set; }
        [Required]
        
        public string _User { get; set; }
        [Required]
        public string _Password { get; set; }
    }
}
