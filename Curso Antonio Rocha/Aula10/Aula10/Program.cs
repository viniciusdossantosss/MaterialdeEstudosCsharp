namespace Aula10;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("==========Calculadora Simples==========");
        Console.WriteLine("Digite o primeiro número: ");
        double n1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo número: ");
        double n2 = Convert.ToInt32(Console.ReadLine());
        
        Console.WriteLine("\nEscolha uma operação: ");
        Console.WriteLine("1. Adição (+)");
        Console.WriteLine("2. Subtrair (-)");
        Console.WriteLine("3. Multiplicar (*)");
        Console.WriteLine("4. Dividir (/)");
        Console.WriteLine("Digite o número da operação: ");
        int operation = Convert.ToInt32(Console.ReadLine());
        
        double result = 0;
        
        if (operation == 1)
        {
            result = n1 + n2;
        }
        else if (operation == 2)
        {
            result = n1 - n2;
        }
        else if (operation == 3)
        {
            result = n1 * n2;
        }
        else if (operation == 4)
        {
            if (n2 == 0)
            {
                Console.WriteLine("Erro: Não é possivel dividir um número por 0");
            }
            else
            {
                result = n1 / n2;
            }
        }
        else
        {
            Console.WriteLine("Operação Invalida");
        }
        Console.WriteLine("Resultado : {0}", result);
    }
}

