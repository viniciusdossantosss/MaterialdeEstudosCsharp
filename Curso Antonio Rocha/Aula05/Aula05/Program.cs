namespace Aula05;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Digite o primeiro numero: ");
        int numero = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int numero2 =  Convert.ToInt32(Console.ReadLine());
        
        int soma = numero + numero2;
        int subtracao = numero - numero2;
        int multiplicacao = numero * numero2;
        int division = numero / numero2;
        int modulo = numero % numero2;
        
        Console.WriteLine("O valor da soma é " + soma);
        Console.WriteLine("O valor da subtração é " + subtracao);
        Console.WriteLine("O valor da multiplicação " + multiplicacao);
        Console.WriteLine("O valor da division " + division);
        Console.WriteLine("O valor da modulo " + modulo);
    }
}