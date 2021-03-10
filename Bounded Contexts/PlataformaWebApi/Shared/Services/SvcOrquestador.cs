using Common.Models;
using LoginApi.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class SvcOrquestador
    {
        public SvcSeguridad _svcSeguridad { get; set; }
        public SvcCredenciales _svcCredenciales { get; set; }
        public SvcDatosUsuario _svcDatosUsuario { get; set; }


        public SvcOrquestador(SvcSeguridad svcSeguridad,
                              SvcCredenciales svcCredenciales,
                              SvcDatosUsuario svcDatosUsuario
            )
        {
            this._svcSeguridad = svcSeguridad;
            this._svcCredenciales = svcCredenciales;
            this._svcDatosUsuario = svcDatosUsuario;
        }

        public List<DatosUsuario> GetUsuarios(string id)
        {
            return _svcDatosUsuario.GetUsuarios(id);
        }

        public async Task<bool> CreateUsuario(DatosUsuario usuario)
        {
            if(await this._svcDatosUsuario.CreateUsuario(usuario))
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

        public async Task<bool> ReplaceUsuario(DatosUsuario usuario)
        {
            if (await this._svcDatosUsuario.ReplaceUsuario(usuario))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public string AutorizarAcceso(Credenciales cre)
        {
            
            var user = _svcSeguridad.AuthenticateUser(cre);
            if(user != null)
            {
                return _svcSeguridad.GenerateJWT(user);
            }
            return String.Empty;


        }


    }
}
