namespace Aula07;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==== Operadores de atribuição ====");
        
        int x = 10;
        Console.WriteLine("\nValor incial da variavel x : {0}", x);

        x = 20;
        Console.WriteLine("\nAtribuição Simples (=)");
        Console.WriteLine("Valor de x é {0}", x);
        
        // Atribuição composta(Incremento)
        x++; //Equivale a x = x + 1
        
        Console.WriteLine("\n Atribuição Composta Incremento (++)");
        Console.WriteLine("Novo valor de x : {0}", x);
        
        // Atribuição composta(+=)
        x += 10; //Equivale a x = x + 10
        
        Console.WriteLine("\n Atribuição Composta Incremento (+=)");
        Console.WriteLine("Novo valor de x : {0}", x);
        
        // Atribuição composta(-=)
        x -= 10; //Equivale a x = x - 10
        
        Console.WriteLine("\n Atribuição Composta Incremento (-=)");
        Console.WriteLine("Novo valor de x : {0}", x);
        
        // Atribuição composta(*=)
        x *= 10; //Equivale a x = x * 10
        
        Console.WriteLine("\n Atribuição Composta Incremento (*=)");
        Console.WriteLine("Novo valor de x : {0}", x);
        
        // Atribuição composta(/=)
        x /= 10; //Equivale a x = x + 10
        
        Console.WriteLine("\n Atribuição Composta Incremento (/=)");
        Console.WriteLine("Novo valor de x : {0}", x);
    }
}