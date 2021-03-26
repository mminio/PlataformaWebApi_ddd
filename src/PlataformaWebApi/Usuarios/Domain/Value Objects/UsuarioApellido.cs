namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioApellido
    {
        public string Apellido { get; private set; }
        public UsuarioApellido(string apellido)
        {
            // validaciones 
            Apellido = apellido;

        }

    }
}