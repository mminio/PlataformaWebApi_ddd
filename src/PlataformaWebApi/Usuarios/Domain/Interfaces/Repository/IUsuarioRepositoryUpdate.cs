using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Domain.Interfaces.Repository
{
    public interface IUsuarioRepositoryUpdate
    {
        void Update(Usuario usuario);
    }
}
