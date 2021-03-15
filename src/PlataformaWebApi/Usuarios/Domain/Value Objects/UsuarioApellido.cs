namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioApellido
    {
        public string Apellido { get; }
        public UsuarioApellido(string ap)
        {
            // validaciones 
            this.Apellido = ap;

        }

        public UsuarioApellido()
        {
        }
    }
}