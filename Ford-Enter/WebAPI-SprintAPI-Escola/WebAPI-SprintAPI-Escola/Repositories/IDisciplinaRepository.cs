using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public interface IDisciplinaRepository
{
    Task<IEnumerable<Disciplina>> ListarTodos();
    Task<Disciplina?> BuscarPorId(int id); 
    Task Adicionar(Disciplina disciplina);
    Task Atualizar(Disciplina disciplina);
    Task Deletar(Disciplina disciplina);
}