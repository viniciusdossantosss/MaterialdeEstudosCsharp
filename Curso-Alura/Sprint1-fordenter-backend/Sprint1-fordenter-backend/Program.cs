namespace Sprint1_fordenter_backend;

class Program
{
    static void Main(string[] args)
    {
        Pedido pedido = new Pedido();
        bool continuar = true;

        while (continuar)
        {
            Console.Clear();
            Console.WriteLine("=== Sistema de Lanchonete ===");
            Console.WriteLine("1. Adicionar Lanche");
            Console.WriteLine("2. Adicionar Bebida");
            Console.WriteLine("3. Ver Pedido");
            Console.WriteLine("4. Finalizar Pedido");
            Console.WriteLine("5. Sair");
            Console.Write("Escolha uma opção: ");

            string? opcao = Console.ReadLine();

            switch (opcao)
            {
                case "1":
                    AdicionarLanche(pedido);
                    break;
                case "2":
                    AdicionarBebida(pedido);
                    break;
                case "3":
                    pedido.ExibirPedido();
                    Console.WriteLine("\nPressione qualquer tecla para voltar...");
                    Console.ReadKey();
                    break;
                case "4":
                    pedido.ExibirPedido();
                    Console.WriteLine("\nPedido finalizado! Obrigado pela preferência.");
                    continuar = false;
                    break;
                case "5":
                    continuar = false;
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    Console.ReadKey();
                    break;
            }
        }
    }

    static void AdicionarLanche(Pedido pedido)
    {
        try
        {
            Console.Write("Código do Lanche: ");
            string? codigoInput = Console.ReadLine();
            if (string.IsNullOrEmpty(codigoInput)) throw new FormatException();
            int codigo = int.Parse(codigoInput);

            Console.Write("Descrição do Lanche: ");
            string? descricao = Console.ReadLine();
            if (descricao == null) descricao = "";

            Console.Write("Preço Base: ");
            string? precoInput = Console.ReadLine();
            if (string.IsNullOrEmpty(precoInput)) throw new FormatException();
            decimal precoBase = decimal.Parse(precoInput);

            Lanche lanche = new Lanche(codigo, descricao, precoBase);

            Console.Write("Deseja adicionar ingredientes extras? (s/n): ");
            string? resposta = Console.ReadLine();
            if (resposta != null && resposta.ToLower() == "s")
            {
                Console.Write("Digite os ingredientes separados por vírgula: ");
                string? extrasInput = Console.ReadLine();
                if (extrasInput != null)
                {
                    string[] extras = extrasInput.Split(',');
                    foreach (var extra in extras)
                    {
                        lanche.AdicionarExtra(extra.Trim());
                    }
                }
            }

            pedido.AdicionarItem(lanche);
            Console.WriteLine("Lanche adicionado com sucesso!");
            Thread.Sleep(1000);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de digitar números corretamente.");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
            Console.ReadKey();
        }
    }

    static void AdicionarBebida(Pedido pedido)
    {
        try
        {
            Console.Write("Código da Bebida: ");
            string? codigoInput = Console.ReadLine();
            if (string.IsNullOrEmpty(codigoInput)) throw new FormatException();
            int codigo = int.Parse(codigoInput);

            Console.Write("Descrição da Bebida: ");
            string? descricao = Console.ReadLine();
            if (descricao == null) descricao = "";

            Console.Write("Preço Base: ");
            string? precoInput = Console.ReadLine();
            if (string.IsNullOrEmpty(precoInput)) throw new FormatException();
            decimal precoBase = decimal.Parse(precoInput);

            Console.Write("Tamanho (300ml, 500ml, 1L): ");
            string? tamanho = Console.ReadLine();
            if (string.IsNullOrEmpty(tamanho)) tamanho = "300ml";

            Bebida bebida = new Bebida(codigo, descricao, precoBase, tamanho);
            pedido.AdicionarItem(bebida);
            Console.WriteLine("Bebida adicionada com sucesso!");
            Thread.Sleep(1000);
        }
        catch (FormatException)
        {
            Console.WriteLine("Erro: Entrada inválida. Certifique-se de digitar números corretamente.");
            Console.ReadKey();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Erro inesperado: {ex.Message}");
            Console.ReadKey();
        }
    }
}
