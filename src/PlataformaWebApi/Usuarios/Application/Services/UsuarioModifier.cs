using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Application.Services
{
    public class UsuarioModifier
    {
        private readonly IUsuarioRepositoryModify _usuarioRepository;

        public UsuarioModifier(IUsuarioRepositoryModify usuarioRepository)
        {
            _usuarioRepository = usuarioRepository;
        }
        public void Modify(int id, IDictionary<string, object> operations)
        {
            _usuarioRepository.Modify(id, operations);
        }
    }
}
