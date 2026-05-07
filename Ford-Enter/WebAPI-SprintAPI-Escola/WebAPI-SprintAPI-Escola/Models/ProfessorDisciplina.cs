namespace WebAPI_SprintAPI_Escola.Models
{
    public class ProfessorDisciplina
    {
        public int IdProfessor { get; set; }
        public int IdDisciplina { get; set; }

        // Propriedades de Navegação
        public Professor Professor { get; set; } = null!;
        public Disciplina Disciplina { get; set; } = null!;
    }
}
