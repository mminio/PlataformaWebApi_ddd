using MediatR;
using PlataformaWebApi.Usuarios.Application.Services;
using System.Threading;
using System.Threading.Tasks;


namespace PlataformaWebApi.Usuarios.Application.Commands.Handlers
{
    public class ModifyUsuarioCommandHandler : IRequestHandler<ModifyUsuarioCommand.Command, ModifyUsuarioCommand.Response>
    {
        private readonly UsuarioModifier _modifier;

        public ModifyUsuarioCommandHandler(UsuarioModifier modifier)
        {
            _modifier = modifier;
        }

        public async Task<ModifyUsuarioCommand.Response> Handle(ModifyUsuarioCommand.Command request, CancellationToken cancellationToken)
        {
            _modifier.Modify(request.id, request.operations);
            return new ModifyUsuarioCommand.Response("Usuario modificado con éxito");
        }
    }
}
