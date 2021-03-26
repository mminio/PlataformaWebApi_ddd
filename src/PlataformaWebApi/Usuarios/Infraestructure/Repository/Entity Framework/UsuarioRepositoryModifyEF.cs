using PlataformaWebApi.Shared.Repository;
using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using PlataformaWebApi.Usuarios.Infraestructure.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace PlataformaWebApi.Usuarios.Infraestructure.Repository.Entity_Framework
{
    public class UsuarioRepositoryModifyEF : UsuarioRepositoryEF, IUsuarioRepositoryModify
    {
        private IUsuarioMapper<Usuario> _mapper;
        public UsuarioRepositoryModifyEF(PlataformaWebApiContext context, IUsuarioMapper<Usuario> mapper) : base(context)
        {
            _mapper = mapper;
        }


        public void Modify(int id, IDictionary<string, object> operations)
        {
            var usuario = this._context.Usuarios.FirstOrDefault(e => e.Id == id);
            usuario = _mapper.Map(operations, usuario);
            this._context.SaveChanges();
        }
    }
}
