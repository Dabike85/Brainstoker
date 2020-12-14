using ProjetoBramStoker.Models;

namespace ProjetoBramStoker
{
    public static class SessionDados
    {
        public static Usuario UsuarioLogado;
        public static bool Logado;

        public static void FezLogin(Usuario u)
        {
            UsuarioLogado = u;
            Logado = true;
        }

        public static void FezLogout(Usuario u)
        {
            UsuarioLogado = null;
            Logado = false;
        }
    }
}
