namespace PlataformaWebApi.Usuarios.Domain
{
    public class UsuarioEdad
    {
        public UsuarioEdad(short edad)
        {
            Edad = edad;
        }

        public short Edad { get; private set; }
    }
}