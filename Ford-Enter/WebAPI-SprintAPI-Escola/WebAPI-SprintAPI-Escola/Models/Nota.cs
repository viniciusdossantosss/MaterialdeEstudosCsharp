namespace WebAPI_SprintAPI_Escola.Models
{
    public class Nota
    {
        public int IdNota { get; set; }
        public int IdAluno { get; set; }
        public int IdDisciplina { get; set; }
        public int IdTurma { get; set; }
        public decimal ValorNota { get; set; }
        public int Unidade { get; set; }

        // Propriedades de Navegação
        public Aluno Aluno { get; set; } = null!;
        public Disciplina Disciplina { get; set; } = null!;
        public Turma Turma { get; set; } = null!;
    }
}
