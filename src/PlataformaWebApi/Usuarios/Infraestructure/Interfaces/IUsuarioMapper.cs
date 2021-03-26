using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Infraestructure.Interfaces
{
    public interface IUsuarioMapper<Usuario>
    {
        public Usuario Map(object data, Usuario entity);
    }
}
