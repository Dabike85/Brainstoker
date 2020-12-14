using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Models
{
    public class Cidade
    {
        public int CidadeID { get; set; }
        public int EstadoID { get; set; } 
        public string Nome { get; set; }
    }
}
