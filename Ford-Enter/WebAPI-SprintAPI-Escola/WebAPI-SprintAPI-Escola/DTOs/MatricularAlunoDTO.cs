using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class MatricularAlunoDTO
{
    [Required(ErrorMessage = "O aluno é obrigatório.")]
    public int IdAluno { get; set; }

    [Required(ErrorMessage = "A turma é obrigatória.")]
    public int IdTurma { get; set; }
}