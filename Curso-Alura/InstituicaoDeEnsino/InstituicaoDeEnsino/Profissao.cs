namespace InstituicaoDeEnsino;

public abstract class Profissao
{
    public string Titulo { get; set; }

    public Profissao(string titulo)
    {
        Titulo = titulo;
    }
}