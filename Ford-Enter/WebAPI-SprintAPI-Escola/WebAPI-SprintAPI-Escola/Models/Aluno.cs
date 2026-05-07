using System.Collections.Generic;

namespace WebAPI_SprintAPI_Escola.Models
{
    public class Aluno
    {
        public int IdAluno { get; set; }
        public string Nome { get; set; } = string.Empty;
        public string Cpf { get; set; } = string.Empty;
        public string Telefone { get; set; } = string.Empty;
        public string Rua { get; set; } = string.Empty;
        public string Cep { get; set; } = string.Empty;
        public string Cidade { get; set; } = string.Empty;
        public string Estado { get; set; } = string.Empty;
        public string Bairro { get; set; } = string.Empty;

        // Propriedades de Navegação
        public ICollection<AlunoResponsavel> AlunoResponsaveis { get; set; } = new List<AlunoResponsavel>();
        public ICollection<AlunoTurma> AlunoTurmas { get; set; } = new List<AlunoTurma>();
        public ICollection<Nota> Notas { get; set; } = new List<Nota>();
    }
}
