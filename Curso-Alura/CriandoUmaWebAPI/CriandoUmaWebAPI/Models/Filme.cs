using System.ComponentModel.DataAnnotations;

namespace CriandoUmaWebAPI.Models;

public class Filme
{ 
    public int Id { get; set; }
    [Required(ErrorMessage = "o título do filme é obrigatório")]
    public string Titulo { get; set; }
    [Required(ErrorMessage = "O gênero do filme é obrigatório")]
    [MaxLength(50, ErrorMessage = "O gênero deve ter no máximo 50 caracteres")]
    public string Genero { get; set; }
    [Required]
    [Range(70, 600, ErrorMessage = "A duração deve estar entre 70 e 600 minutos")]
    public int Duracao { get; set; }

   
}