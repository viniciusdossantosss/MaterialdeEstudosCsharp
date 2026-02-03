namespace Aula09;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("====Operadores Lógicos====");

        bool isLogged = true;
        bool hasAdminAcess = false;
        
        Console.WriteLine("\nInformações do Usuário: ");
        Console.Write("Usuario logado: " + isLogged);
        Console.WriteLine("Acesso ao painel de administrador: " + hasAdminAcess);
        
        //Operador &&
        if (isLogged && hasAdminAcess)
        {
            Console.WriteLine("Acesso ao painel de administrador concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao painel de administrador negado");
        }
        
        //Operador || - Ou
        
        if (isLogged || hasAdminAcess)
        {
            Console.WriteLine("Acesso ao sistema concedido");
        }
        else
        {
            Console.WriteLine("Acesso ao sistema negado");
        }
        
        //Operador de negação !
        if (!isLogged)
        {
            Console.WriteLine("Usuário não está logado");
        }
        else
        {
            Console.WriteLine("Usuário está logado");
        }
        
        
    }
}