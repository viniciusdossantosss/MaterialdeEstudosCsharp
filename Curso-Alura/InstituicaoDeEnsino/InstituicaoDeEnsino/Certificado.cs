namespace InstituicaoDeEnsino;

public class Certificado
{
    public Profissao profissao;
    public Certificado(Profissao profissao)
    {
        Console.WriteLine($"Certificado emitido para: {profissao.Titulo}");
    }
}