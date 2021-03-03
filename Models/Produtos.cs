using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlueModasBack.Models
{
    [Table("Produtos")]
    public class Produtos
    {
        [Key]
        public int _id { get; set; }

        [Required(ErrorMessage = "Nome é obrigatório")]
        public string nome { get; set; }
        [Required(ErrorMessage = "Preço é obrigatório")]
        public double preco { get; set; }

        [Required(ErrorMessage = "Imagem é obrigatório")]
        public string imagem_url { get; set; }

    }
}
