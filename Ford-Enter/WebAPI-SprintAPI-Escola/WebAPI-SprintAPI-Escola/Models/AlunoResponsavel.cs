namespace WebAPI_SprintAPI_Escola.Models
{
    public class AlunoResponsavel
    {
        public int IdAluno { get; set; }
        public int IdResponsavel { get; set; }

        // Propriedades de Navegação
        public Aluno Aluno { get; set; } = null!;
        public Responsavel Responsavel { get; set; } = null!;
    }
}
