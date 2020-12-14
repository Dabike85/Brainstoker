using ProjetoBramStoker.Services.Base;
using ProjetoBramStoker.Models;

namespace ProjetoBramStoker.Services
{
    public interface IProdutoService : IServiceBase<Produto>
    {
        Produto Update(Produto ent);
    }
}
