using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Models
{
    public class Doacao
    {
        public int ProdutoID { get; set; }
        public int UsuarioID { get; set; }
        public int DoacaoStatusID { get; set; }
        public DateTime Data { get; set; }
    }
}
