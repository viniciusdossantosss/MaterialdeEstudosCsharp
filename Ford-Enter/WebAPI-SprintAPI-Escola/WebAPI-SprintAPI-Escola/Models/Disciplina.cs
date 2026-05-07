using System.Collections.Generic;

namespace WebAPI_SprintAPI_Escola.Models
{
    public class Disciplina
    {
        public int IdDisciplina { get; set; }
        public string Nome { get; set; } = string.Empty;
        public int IdTurma { get; set; }

        // Propriedades de Navegação
        public Turma Turma { get; set; } = null!;
        public ICollection<ProfessorDisciplina> ProfessorDisciplinas { get; set; } = new List<ProfessorDisciplina>();
    }
}
