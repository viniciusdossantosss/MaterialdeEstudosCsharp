namespace Aula08;

public  class Program
{
    public static void Main()
    {
        Console.WriteLine("Operadores Relacionais");
        Console.WriteLine("\nDigite o primeiro numero: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Digite o segundo numero: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        
        //Operador de igualdade ==
        
        string resultado;

        if (num1 == num2)
        {
            resultado = "numero 1 é igual ao numero 2";
        }
        else
        {
            resultado = "numero 1 é diferente do numero 2";
        }
        Console.WriteLine("\nIgualdade (==): {0}", resultado);
        
        //Operador de diferença !=

        if (num1 != num2)
        {
            resultado = "numero 1 é diferente do numero 2";
        }
        else
        {
            resultado = "numero 1 é igual ao  numero 2";
        }
        Console.WriteLine("\nDiferença (!=): {0}", resultado);
        
        //Operador maior que >

        if (num1 > num2)
        {
            resultado = "numero 1 é maior que o numero 2";
        }
        else
        {
            resultado = "numero 1 não é maior que o numero 2";
        }
        Console.WriteLine("\nIgualdade (==): {0}", resultado);
        
        //Operador menor que <

        if (num1 < num2)
        {
            resultado = "numero 1 é menor que o numero 2";
        }
        else
        {
            resultado = "numero 1 não é menor que o numero 2";
        }
        Console.WriteLine("\nIgualdade (==): {0}", resultado);
        
        //Operador maior ou igual >=

        if (num1 >= num2)
        {
            resultado = "numero 1 é maior ou igual ao numero 2";
        }
        else
        {
            resultado = "numero 1 não é maior ou igual ao numero 2";
        }
        Console.WriteLine("\nIgualdade (==): {0}", resultado);
        
        //Operador maior ou igual <=

        if (num1 <= num2)
        {
            resultado = "numero 1 é menor ou igual ao numero 2";
        }
        else
        {
            resultado = "numero 1 não é menor ou igual ao numero 2";
        }
        Console.WriteLine("\nIgualdade (==): {0}", resultado);
    }
} 