namespace Biblioteca;

public class Livro
{
    public string Titulo { get; set; }
    public string Autor { get; set; }

    public void Informacoes(){
        Console.WriteLine("Titulo: " + Titulo);
        Console.WriteLine("Autor: " + Autor);
        
    }
}