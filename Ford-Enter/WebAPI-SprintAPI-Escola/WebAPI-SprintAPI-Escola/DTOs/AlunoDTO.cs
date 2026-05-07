using System.ComponentModel.DataAnnotations;

namespace WebAPI_SprintAPI_Escola.DTOs;

public class AlunoDTO
{
    [Required(ErrorMessage = "O nome é obrigatório.")]
    [StringLength(300, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 300 caracteres")]
    public string Nome { get; set; } = string.Empty;
    [Required(ErrorMessage = "O CPF é obrigatório.")]
    public string Cpf { get; set; } = string.Empty;
    [Required(ErrorMessage = "O telefone é obrigatório.")]
    public string Telefone { get; set; } = string.Empty;
    [Required(ErrorMessage = "A rua é obrigatória.")]
    [StringLength(300, MinimumLength = 3, ErrorMessage = "A rua deve ter entre 3 e 300 caracteres")]
    public string Rua { get; set; } = string.Empty;
    [Required(ErrorMessage = "O cep é obrigatório.")]
    public string Cep { get; set; } = string.Empty;
    [Required(ErrorMessage = "A cidade é obrigatória.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "A cidade deve ter entre 3 e 50 caracteres")]
    public string Cidade { get; set; } = string.Empty;
    [Required(ErrorMessage = "O estado é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O estado deve ter entre 3 e 50 caracteres")]
    public string Estado { get; set; } = string.Empty;
    [Required(ErrorMessage = "O bairro é obrigatório.")]
    [StringLength(50, MinimumLength = 3, ErrorMessage = "O bairro deve ter entre 3 e 50 caracteres")]
    public string Bairro { get; set; } = string.Empty;
}