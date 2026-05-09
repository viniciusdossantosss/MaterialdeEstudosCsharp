using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class NotaDTO
{
    [Required(ErrorMessage = "O Id do aluno é obrigatório.")]
    public int IdAluno { get; set; }

    [Required(ErrorMessage = "O Id da disciplina é obrigatório.")]
    public int IdDisciplina { get; set; }

    [Required(ErrorMessage = "O Id da turma é obrigatório.")]
    public int IdTurma { get; set; }

    [Required(ErrorMessage = "O valor da nota é obrigatório.")]
    [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10.")]
    public decimal ValorNota { get; set; }

    [Required(ErrorMessage = "A unidade é obrigatória.")]
    public int Unidade { get; set; }
}