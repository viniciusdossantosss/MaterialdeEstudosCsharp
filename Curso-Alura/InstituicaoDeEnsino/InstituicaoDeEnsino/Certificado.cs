namespace InstituicaoDeEnsino;

public class Certificado
{
    public Profissao Profissao { get; private set; }

    public Certificado(Profissao profissao)
    {
        Profissao = profissao;
        Console.WriteLine($"Certificado emitido para: {Profissao.Titulo}");
    }
}