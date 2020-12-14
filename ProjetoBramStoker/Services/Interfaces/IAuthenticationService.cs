using ProjetoBramStoker.Models;
using ProjetoBramStoker.Services.Base;

namespace ProjetoBramStoker.Services
{
    public interface IAuthenticationService : IServiceBase<Usuario>
    {
        Usuario Cadastrar(Usuario ent);
        Usuario Login(Usuario ent);
    }
}
