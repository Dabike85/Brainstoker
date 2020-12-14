using ProjetoBramStoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Services
{
    public class EnderecoService : IEnderecoService
    {
        private BramStokerContext Contexto = new BramStokerContext();

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Endereco> GetAll()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Endereco> GetManyBy(Func<Endereco, bool> ent)
        {
            throw new NotImplementedException();
        }

        public Endereco GetOne(int id)
        {
            throw new NotImplementedException();
        }

        public Endereco GetOneBy(Func<Endereco, bool> ent)
        {
            throw new NotImplementedException();
        }

        public void Save(Endereco ent)
        {
            throw new NotImplementedException();
        }

        Endereco IEnderecoService.Save(Endereco ent)
        {
            var el = Contexto.Endereco.Add(ent);
            Contexto.SaveChanges();
            return el.Entity;
        }
    }
}
