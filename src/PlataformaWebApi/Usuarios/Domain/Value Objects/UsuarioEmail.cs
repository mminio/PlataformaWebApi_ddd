namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioEmail
    {
        public string _email { get; set; }
        public UsuarioEmail(string email)
        {
            if(email.Length > 50)
            {
                // tal cosa
            }
            else
            {
                _email = email;
            }
        }


    }
}