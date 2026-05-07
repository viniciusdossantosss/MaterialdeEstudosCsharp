using System.Collections.Generic;

namespace WebAPI_SprintAPI_Escola.Models
{
    public class Responsavel
    {
        public int IdResponsavel { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string GrauParentesco { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        // Propriedades de Navegação
        public ICollection<AlunoResponsavel> AlunoResponsaveis { get; set; } = new List<AlunoResponsavel>();
    }
}
