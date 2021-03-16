namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioApellido
    {
        public string Apellido { get; }
        public UsuarioApellido(string apellido)
        {
            // validaciones 
            Apellido = apellido;

        }

    }
}