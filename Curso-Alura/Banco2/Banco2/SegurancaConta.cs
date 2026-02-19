namespace Banco2;

internal class SegurancaConta
{
    public bool ValidarSaque(decimal valor)
    {
        if (valor > 1000)
        {
            return false;
        }
        else
        {
            return true;
        }
    }
}