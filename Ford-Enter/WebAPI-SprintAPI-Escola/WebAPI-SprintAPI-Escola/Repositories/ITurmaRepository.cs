using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public interface ITurmaRepository
{
    Task<IEnumerable<Turma>> ListarTodos();
    Task<Turma?> BuscarPorId(int id); 
    Task Adicionar(Turma turma);
    Task Atualizar(Turma turma);
    Task Deletar(Turma turma);
}