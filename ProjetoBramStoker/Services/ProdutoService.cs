using ProjetoBramStoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Services
{
    public class ProdutoService : IProdutoService
    {
        private BramStokerContext Contexto = new BramStokerContext();

        public void Delete(int id)
        {
            var ent = GetOne(id);
            Contexto.Produto.Remove(ent);
            Contexto.SaveChanges();
        }

        public IEnumerable<Produto> GetAll()
        {
            return Contexto.Produto;
        }

        public IEnumerable<Produto> GetManyBy(Func<Produto, bool> ent)
        {
            return Contexto.Produto.ToList().Where(ent);
        }

        public Produto GetOne(int id)
        {
            var ent = GetOneBy(f => f.ProdutoID == id);
            return ent;
        }

        public Produto GetOneBy(Func<Produto, bool> ent)
        {
            return Contexto.Produto.ToList().FirstOrDefault(ent);
        }

        public void Save(Produto ent)
        {
            Contexto.Produto.Add(ent);
            Contexto.SaveChanges();
        }

        public Produto Update(Produto ent)
        {
            var el = Contexto.Produto.Update(ent);
            Contexto.SaveChanges();
            return el.Entity;
        }
    }
}
