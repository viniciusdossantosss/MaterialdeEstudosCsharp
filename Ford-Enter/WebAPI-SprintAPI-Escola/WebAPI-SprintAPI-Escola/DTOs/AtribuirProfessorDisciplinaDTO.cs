using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class AtribuirProfessorDisciplinaDTO
{
    [Required(ErrorMessage = "O professor é obrigatório.")]
    public int IdProfessor { get; set; }

    [Required(ErrorMessage = "A disciplina é obrigatória.")]
    public int IdDisciplina { get; set; }
}