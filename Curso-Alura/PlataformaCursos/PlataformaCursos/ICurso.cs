namespace PlataformaCursos;

public interface ICurso
{
    void ValidarConteudo();
    void PublicarCurso();
    string NomeCurso { get; }
}