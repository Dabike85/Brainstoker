using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Models
{
    public class Produto
    {

        public int ProdutoID { get; set; }
        public string Nome { get; set; }
        public bool Doado { get ; set ; }
        public int TipoID { get; set; }


    }
}
