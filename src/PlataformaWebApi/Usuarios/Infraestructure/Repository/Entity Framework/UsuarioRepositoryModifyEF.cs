using PlataformaWebApi.Shared.Repository;
using PlataformaWebApi.Usuarios.Domain;
using PlataformaWebApi.Usuarios.Domain.Interfaces.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Usuarios.Infraestructure.Repository.Entity_Framework
{
    public class UsuarioRepositoryModifyEF : UsuarioRepositoryEF, IUsuarioRepositoryModify
    {
        public UsuarioRepositoryModifyEF(PlataformaWebApiContext context) : base(context)
        {
        }

        public void Modify(Usuario usuarioNuevo)
        {
            var usuarioActual = this._context.Usuarios.Find(usuarioNuevo.Id);

            foreach (PropertyInfo propUsActual in usuarioActual.GetType().GetProperties())
            {
                var valorNuevo = usuarioNuevo.GetType().GetProperty(propUsActual.Name).GetValue(usuarioNuevo, null);
                var valorActual = usuarioActual.GetType().GetProperty(propUsActual.Name).GetValue(usuarioActual, null);

                if (valorActual != valorNuevo)
                    propUsActual.SetValue(usuarioActual, valorNuevo, null);
            }

            this._context.SaveChanges();
        }
    }
}
