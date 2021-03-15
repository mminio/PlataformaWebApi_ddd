namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioNombre
    {
        public UsuarioNombre(string nombre)
        {
            Nombre = nombre;
        }

        public string Nombre { get; }
    }
}