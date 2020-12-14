using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Models
{
    public class Usuario
    {
        public int UsuarioID { get; set; }
        public int CidadeID { get; set; }
        public DateTime DataCadastro { get; set; }
        public int UsuarioStatusID { get; set; }

        public string Senha { get; set; }
        public string Telefone { get; set; }
        public string CPF { get; set; }
        public string Email { get; set; }
        public string Nome { get; set; }

    }
}
