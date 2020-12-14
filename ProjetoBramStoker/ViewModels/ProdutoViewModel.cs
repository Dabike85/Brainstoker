using ProjetoBramStoker.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.ViewModels
{
    public class ProdutoViewModel
    {
        public int ProdutoID { get; set; }
        public string Imagem { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }
        public int Avaliacao { get; set; }
        public string Modelo { get; set; }
        public string Cor { get; set; }

        public Usuario Usuario { get; set; }

    }
}
