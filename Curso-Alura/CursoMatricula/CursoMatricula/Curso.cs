namespace CursoMatricula;

public class Curso
{
    public String Nome { get; set; }
    public int VagasTotais { get; }
    private List<Estudante> matricula;
    
    public Curso(string nome, int vagasTotais)
    {
        Nome = nome;
        VagasTotais = vagasTotais;
    }
    
}