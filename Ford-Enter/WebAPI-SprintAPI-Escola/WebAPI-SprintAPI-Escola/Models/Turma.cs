using System.Collections.Generic;

namespace WebAPI_SprintAPI_Escola.Models
{
    public class Turma
    {
        public int IdTurma { get; set; }
        public string Serie { get; set; } = string.Empty;
        public string Letra { get; set; } = string.Empty;
        public int Ano { get; set; }

        // Propriedades de Navegação
        public ICollection<AlunoTurma> AlunoTurmas { get; set; } = new List<AlunoTurma>();
        public ICollection<Disciplina> Disciplinas { get; set; } = new List<Disciplina>();
    }
}
