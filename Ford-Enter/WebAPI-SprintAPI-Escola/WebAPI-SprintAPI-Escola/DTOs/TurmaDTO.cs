using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class TurmaDTO
{
    [Required(ErrorMessage = "A série é obrigatória.")]
    public string Serie { get; set; } = string.Empty;

    [Required(ErrorMessage = "A letra é obrigatória.")]
    public string Letra { get; set; } = string.Empty;

    [Required(ErrorMessage = "O ano é obrigatório.")]
    public int Ano { get; set; }
}