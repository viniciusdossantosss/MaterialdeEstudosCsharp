namespace Escola_media;

public class Estudante
{
    public String Nome { get; set; }
    public double Nota1 { get; set; }
    public double Nota2 { get; set; }
    

    public Estudante(string nome)
    {
        Nome = nome;
    }

    public double Media
    {
        get
        {
            return (Nota1 + Nota2) / 2;
        }
    }

    public string Situacao
    {
        get
        {
            return Media >= 6 ? "Aprovado" : "Reprovado";
        }
    }
}