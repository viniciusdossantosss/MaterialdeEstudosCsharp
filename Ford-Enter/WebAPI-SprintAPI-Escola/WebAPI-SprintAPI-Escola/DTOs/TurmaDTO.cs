using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class TurmaDTO
{
    [Required(ErrorMessage = "A série é obrigatória.")]
    [StringLength(10, ErrorMessage = "A série deve ter no máximo 10 caracteres.")]
    public string Serie { get; set; } = string.Empty;

    [Required(ErrorMessage = "A letra da turma é obrigatória.")]
    [StringLength(1, ErrorMessage = "A letra deve ter apenas 1 caractere.")]
    public string Letra { get; set; } = string.Empty;

    [Required(ErrorMessage = "O ano é obrigatório.")]
    [Range(2000, 2100, ErrorMessage = "O ano deve ser válido.")]
    public int Ano { get; set; }
}