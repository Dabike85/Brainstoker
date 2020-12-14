using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.Models
{
    public class DoacaoStatus
    {
        public int DoacaoStatusID { get; set; }
        public int ProdutoID { get; set; }
        public int UsuarioID { get; set; }
        public string Descricao { get; set; }
    }
}
