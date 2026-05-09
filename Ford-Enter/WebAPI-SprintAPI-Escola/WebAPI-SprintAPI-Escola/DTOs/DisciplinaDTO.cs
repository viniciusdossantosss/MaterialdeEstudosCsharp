using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class DisciplinaDTO
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(200, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 200 caracteres")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O Id da turma é obrigatório.")]
    public int IdTurma { get; set; }
}