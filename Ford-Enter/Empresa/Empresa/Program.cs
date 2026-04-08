using Empresa;

// --- Criando instâncias de Gerente ---
Gerente gerente1 = new Gerente("Alice Silva", 5000m, "TI");
Gerente gerente2 = new Gerente("Bruno Costa", 6000m, "Vendas");

// --- Criando instâncias de Desenvolvedor ---
Desenvolvedor dev1 = new Desenvolvedor("Carla Souza", 4000m, "C#");
Desenvolvedor dev2 = new Desenvolvedor("Daniel Lima", 4500m, "Java");

// --- Exibindo os dados ---
Console.WriteLine("--- DADOS DOS GERENTES ---");
gerente1.exibirDados();
Console.WriteLine();
gerente2.exibirDados();

Console.WriteLine("\n--- DADOS DOS DESENVOLVEDORES ---");
dev1.exibirDados();
Console.WriteLine();
dev2.exibirDados();