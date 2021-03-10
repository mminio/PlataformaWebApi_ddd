using Common;
using LoginApi.Repository;
using LoginApi.Repository.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Domain.Services
{
    public class SvcCredenciales
    {
        private LoginApiDbContext _context;

        public SvcCredenciales()
        {
            this._context = new LoginApiDbContext();
        }
       

        public Credenciales GetAccount(Credenciales account)
        {
            var acc = _context.Credenciales.FirstOrDefault(a => a._User == account._User);
            return acc;
        }

    }
}
