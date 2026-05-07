using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class NotaDTO
{
    [Required(ErrorMessage = "O aluno é obrigatório.")]
    public int IdAluno { get; set; }

    [Required(ErrorMessage = "A disciplina é obrigatória.")]
    public int IdDisciplina { get; set; }

    [Required(ErrorMessage = "A turma é obrigatória.")]
    public int IdTurma { get; set; }

    [Required(ErrorMessage = "O valor da nota é obrigatório.")]
    [Range(0, 10, ErrorMessage = "A nota deve estar entre 0 e 10.")]
    public decimal ValorNota { get; set; }

    [Required(ErrorMessage = "A unidade (bimestre/trimestre) é obrigatória.")]
    [Range(1, 4, ErrorMessage = "A unidade deve ser entre 1 e 4.")]
    public int Unidade { get; set; }
}