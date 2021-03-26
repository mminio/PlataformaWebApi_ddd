using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlataformaWebApi.Credenciales.Application.Services
{
    public static class CredencialesPasswordEncryptor
    {
        public static string key = "asd@wk123@0:9?j¡1smajkp241";

        public static string Encrypt(string password)
        {
            password += key;
            var passwordBytes = Encoding.UTF8.GetBytes(password);
            return Convert.ToBase64String(passwordBytes);
        }
    }
}
