using System.ComponentModel.DataAnnotations;

namespace backendApi.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório.")]
        [MinLength(3, ErrorMessage = "Esse campo deve conter no mínimo 3 caracteres.")]
        [MaxLength(60, ErrorMessage = "Esse campo deve conter no máximo 60 caracteres.")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Esse campo é obrigatório.")]
        [Range(0, int.MaxValue, ErrorMessage = "Insira um valor válido.")]
        public decimal Price { get; set; }

    }
}