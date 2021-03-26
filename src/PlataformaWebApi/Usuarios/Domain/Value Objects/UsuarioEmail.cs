namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioEmail
    {
        public string Email { get; private set; }
        public UsuarioEmail(string email)
        {
            if(email.Length > 50)
            {
                // tal cosa
            }
            else
            {
                Email = email;
            }
        }


    }
}