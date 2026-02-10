namespace PlataformaCursos;

public class CursoProgramacao : ICurso
{
    public string NomeCurso { get; }
    public Instrutor Instrutor { get; }

    public CursoProgramacao(string nomeCurso, Instrutor instrutor)
    {
        NomeCurso = nomeCurso;
        Instrutor = instrutor;
    }
    
    public void ValidarConteudo()
    {
        Console.WriteLine($"Validando conteúdo do curso de programação: {NomeCurso}");
    }

    public void PublicarCurso()
    {
        Console.WriteLine($"Curso publicado com sucesso: {NomeCurso} - Instrutor: {Instrutor.Nome} ({Instrutor.Especialidade})");
    }

    
}