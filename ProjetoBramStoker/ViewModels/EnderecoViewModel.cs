using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjetoBramStoker.ViewModels
{
    public class EnderecoViewModel
    {
        public int EnderecoID { get; set; }

        public string Rua { get; set; }
        public int Numero { get; set; }
        public string Complemento { get; set; }
        public string CEP { get; set; }
        public string Bairro { get; set; }

    }
}
