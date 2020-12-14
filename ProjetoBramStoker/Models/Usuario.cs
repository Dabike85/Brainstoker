using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Models
{
    public class Usuario
    {
        [Key]
        public int UsuarioID { get; set; }
        public string Username { get; set; }
        public string Senha { get; set; }
        public string Email { get; set; }
        [ForeignKey("Endereco")]
        public int EnderecoID { get; set; }

        public Endereco Endereco { get; set; }

    }
}
