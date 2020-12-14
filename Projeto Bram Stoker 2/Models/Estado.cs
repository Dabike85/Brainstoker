using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Models
{
    public class Estado
    {
        public int EstadoID { get; set; }
        public string UF { get; set; }
        public string Nome { get; set; }  
        public int UsuarioID { get; set; }
    }
}
