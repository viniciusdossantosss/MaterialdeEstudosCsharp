using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class ResponsavelDTO
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(300, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 300 caracteres")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O grau de parentesco é obrigatório.")]
    public string GrauParentesco { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é obrigatório.")]
    public string Telefone { get; set; } = string.Empty;

    [Required(ErrorMessage = "O email é obrigatório.")]
    [EmailAddress(ErrorMessage = "Email inválido.")]
    public string Email { get; set; } = string.Empty;
}