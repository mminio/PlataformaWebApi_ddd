namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioApellido
    {
        public string apellido { get; set; }
        public UsuarioApellido(string ap)
        {
            // validaciones 
            this.apellido = ap;

        }
    }
}