using ProjetoBramStoker.Models;
using ProjetoBramStoker.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Services
{
    public interface IEnderecoService : IServiceBase<Endereco>
    {
        Endereco Save(Endereco ent);
    }
}
