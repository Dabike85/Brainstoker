using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProjetoBramStoker.Models
{
    public class Produto
    {
        [Key]
        public int ProdutoID { get; set; }
        public string Imagem { get; set; }
        public string Titulo { get; set; }
        public string Descricao { get; set; }
        [ForeignKey("Usuario")]
        public int UsuarioID { get; set; }

        public string Modelo { get; set; }
        public string Cor { get; set; }


        public Usuario Usuario { get; set; }

    }
}
