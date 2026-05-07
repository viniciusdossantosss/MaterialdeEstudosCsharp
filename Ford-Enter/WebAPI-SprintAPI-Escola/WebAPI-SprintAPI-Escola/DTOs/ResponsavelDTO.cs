using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class ResponsavelDTO
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(100, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 100 caracteres.")]
    public string Nome { get; set; } = string.Empty;

    [Required(ErrorMessage = "O grau de parentesco é obrigatório.")]
    [StringLength(20, ErrorMessage = "O grau de parentesco deve ter no máximo 20 caracteres.")]
    public string GrauParentesco { get; set; } = string.Empty;

    [Required(ErrorMessage = "O telefone é obrigatório.")]
    [StringLength(15, ErrorMessage = "O telefone deve ter no máximo 15 caracteres.")]
    public string Telefone { get; set; } = string.Empty;

    [EmailAddress(ErrorMessage = "Email inválido.")]
    [StringLength(100, ErrorMessage = "O email deve ter no máximo 100 caracteres.")]
    public string Email { get; set; } = string.Empty;
}