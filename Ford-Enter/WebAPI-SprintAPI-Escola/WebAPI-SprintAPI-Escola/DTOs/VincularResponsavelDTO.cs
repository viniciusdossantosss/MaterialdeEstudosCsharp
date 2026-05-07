using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class VincularResponsavelDTO
{
    [Required(ErrorMessage = "O aluno é obrigatório.")]
    public int IdAluno { get; set; }

    [Required(ErrorMessage = "O responsável é obrigatório.")]
    public int IdResponsavel { get; set; }
}