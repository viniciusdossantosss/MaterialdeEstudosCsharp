namespace Streaming;

public class Episodio
{
    private List<string> convidados = new List<string>();

    public Episodio(int duracao, int ordem, string titulo)
    {
        Duracao = duracao;
        Ordem = ordem;
        Titulo = titulo;
    }

    public int Duracao { get; }
    public int Ordem { get; }
    public string Titulo { get; }
    public string Resumo => $"Epsódio {Ordem} - {Titulo} - Duração: {Duracao} minutos - Convidados: {String.Join(", ", convidados)}";

    public void AdicionarConvidados(string convidado)
    {
        convidados.Add(convidado);
    }
}