using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class DisciplinaDTO
{
    
    [Required(ErrorMessage = "O nome da disciplina é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 50 caracteres")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "A disciplina deve estar vinculada a uma turma (IdTurma).")]
    public int IdTurma { get; set; }
}
