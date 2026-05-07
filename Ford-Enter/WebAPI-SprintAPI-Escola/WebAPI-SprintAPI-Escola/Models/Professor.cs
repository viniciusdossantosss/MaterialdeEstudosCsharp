using System.Collections.Generic;

namespace WebAPI_SprintAPI_Escola.Models
{
    public class Professor
    {
        public int IdProfessor { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;

        // Propriedades de Navegação
        public ICollection<ProfessorDisciplina> ProfessorDisciplinas { get; set; } = new List<ProfessorDisciplina>();
    }
}
