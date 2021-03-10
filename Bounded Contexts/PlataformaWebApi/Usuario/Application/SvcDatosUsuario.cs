using Common;
using Common.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class SvcDatosUsuario
    {
        public LoginApiDbContext _context { get; set; }
        public SvcDatosUsuario()
        {
            this._context = new LoginApiDbContext();
        }

        public List<DatosUsuario> GetUsuarios(string id)
        {
            int aux;
            if (Int32.TryParse(id, out aux))
            {
                return new List<DatosUsuario>() { (this._context.DatosUsuarios.Find(aux)) };
            }
            else
            {
                return this._context.DatosUsuarios.ToList();

            }
        }

        public async Task<bool> CreateUsuario(DatosUsuario usuario)
        {
            this._context.DatosUsuarios.Add(usuario);

            try
            {
                await this._context.SaveChangesAsync();
                return true;
            }
            catch (Exception)
            {
                return false;
            }


        }

        internal Task<bool> ReplaceUsuario(DatosUsuario usuario)
        {

        }
    }
}
