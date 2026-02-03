namespace Aula06;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("------------Verificador de Números Impares e Pares ----------");
        Console.WriteLine("Digite um numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());

        if (numero % 2 == 0)
        {
            Console.WriteLine("O número é par");
        }
        else
        {
            Console.WriteLine("O número é impar");
        }
    }
}