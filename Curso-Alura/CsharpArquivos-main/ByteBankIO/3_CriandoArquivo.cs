using System.Text;

namespace ByteBankIO;

partial class Program
{
    static void CriarArquivo()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";
        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        {
            var contaComoString = "456,78945,4785.40,Gustavo Santos";
            var encoding = Encoding.UTF8;
            var bytes = encoding.GetBytes(contaComoString);

            fluxoDoArquivo.Write(bytes, 0, bytes.Length);
        }
    }

    static void CriarArquivoComWriter()
    {
        var caminhoNovoArquivo = "contasExportadas.csv";

        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            escritor.Write("456,65465,456.0,Pedro");
        }
    }

    static void TestaEscrita()
    {
        var caminhoNovoArquivo = "teste.txt";
        
        using (var fluxoDoArquivo = new FileStream(caminhoNovoArquivo, FileMode.Create))
        using (var escritor = new StreamWriter(fluxoDoArquivo))
        {
            for (int i = 0; i < 1000000; i++)
            {
                escritor.WriteLine($"Linha {i}");
                
                // O Flush força o StreamWriter a gravar o que está no buffer diretamente no arquivo agora mesmo.
                escritor.Flush(); 
                
                Console.WriteLine($"Linha {i} foi escrita no arquivo. Tecle enter...");
                Console.ReadLine();
            }
        }
    }
}