namespace DadosMedicos;

internal class HistoricoMedico
{
    public string CodigoProntuario { get; }

    public HistoricoMedico(string codigoProntuario)
    {
        CodigoProntuario = codigoProntuario;
    }

    public void ExibirCodigo()
    {
        Console.WriteLine($"Código do prontuário: {CodigoProntuario}");
    }
}