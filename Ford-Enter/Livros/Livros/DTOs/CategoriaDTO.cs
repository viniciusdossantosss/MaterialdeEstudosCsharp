using System.ComponentModel.DataAnnotations;

namespace Livros.DTOs;

public class CategoriaDTO
{
    [Required(ErrorMessage = "O nome da categoria é obrigatório")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome da categoria deve conter entre 3 e 100 caracteres")]
    public string Nome { get; set; }
}