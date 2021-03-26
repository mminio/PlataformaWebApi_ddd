using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Application.DTOs
{
    public class CredencialesPostDTO
    {
        public int Id { get; set; }
        public string _user { get; set; }
        public string _password { get; set; }
    }
}
