using ProjetoBramStoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.ViewModels
{
    public class UsuarioViewModel
    {
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        public int EnderecoID { get; set; }

        public Endereco Endereco { get; set; }

        public IEnumerable<Endereco> Enderecos { get; set; }

    }
}
