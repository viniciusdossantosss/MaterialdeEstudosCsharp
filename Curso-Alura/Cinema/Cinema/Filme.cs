namespace Cinema;

public class Filme
{
    public string Titulo { get; set; }
    public int ClassificacaoEtaria { get; set; }

    public Filme(string titulo, int classificacaoEtaria)
    {
        Titulo = titulo;
        ClassificacaoEtaria = classificacaoEtaria;
    }

    public bool PodeAssistir(int idadeUsuario)
    {
        return ClassificacaoEtaria <= idadeUsuario;
    }
    
    public void ExibirResultado(int idadeUsuario)
    {
        if (PodeAssistir(idadeUsuario))
        {
            Console.WriteLine($"Cliente com {idadeUsuario} pode ver o filme {Titulo}.");
        }
        else
        {
            Console.WriteLine($"Cliente com {idadeUsuario} não pode ver o filme {Titulo}.");
        }
    }
    
    
}