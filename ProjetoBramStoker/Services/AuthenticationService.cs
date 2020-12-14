using ProjetoBramStoker.Models;
using ProjetoBramStoker.Services.Base;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProjetoBramStoker.Services
{
    public class AuthenticationService : IAuthenticationService
    {
        private BramStokerContext Contexto = new BramStokerContext();

        public Usuario Cadastrar(Usuario ent)
        {
            Usuario u = GetOneBy(usuario => usuario.Username == ent.Username);
            if (u != null) {
                throw new Exception("Esse usuario já está cadastrado");
            } else {
                Save(ent);
                return ent;
            }
        }

        public void Delete(int id)
        {
            var ent = GetOne(id);
            Contexto.Usuario.Remove(ent);
        }

        public IEnumerable<Usuario> GetAll()
        {
            return Contexto.Usuario;
        }

        public IEnumerable<Usuario> GetManyBy(Func<Usuario, bool> ent)
        {
            return Contexto.Usuario.ToList().Where(ent);
        }

        public Usuario GetOne(int id)
        {
            return Contexto.Usuario.FirstOrDefault(f => f.UsuarioID == id);
        }

        public Usuario GetOneBy(Func<Usuario, bool> ent)
        {
            return Contexto.Usuario.ToList().FirstOrDefault(ent);
            //return Contexto.Usuario.FirstOrDefault(ent);
        }

        public Usuario Login(Usuario ent)
        {
            var u = GetOneBy(f => f.Username == ent.Username && f.Senha == ent.Senha);
            if (u == null)
            {
                throw new Exception("O usuario não está cadastrado");
            } else
            {
                return u;
            }
        }

        public void Save(Usuario ent)
        {
            Contexto.Usuario.Add(ent);
            Contexto.SaveChanges();
        }
    }
}
