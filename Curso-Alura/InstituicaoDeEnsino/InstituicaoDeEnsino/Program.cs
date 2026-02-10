using InstituicaoDeEnsino;

public class Programa
{
    public static void Main(string[] args)
    {
        Analista analista = new Analista("Analista de Sistemas");
        Docente docente = new Docente("Docente de Matemática");
        Console.WriteLine(analista.Titulo);
        Certificado cerf1 = new Certificado(analista); 
        Certificado certf2 = new Certificado(docente);
    }
}

