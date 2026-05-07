namespace WebAPI_SprintAPI_Escola.Models
{
    public class AlunoTurma
    {
        public int IdAluno { get; set; }
        public int IdTurma { get; set; }

        // Propriedades de Navegação
        public Aluno Aluno { get; set; } = null!;
        public Turma Turma { get; set; } = null!;
    }
}
