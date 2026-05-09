using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public interface IProfessorRepository
{
    Task<IEnumerable<Professor>> ListarTodos();
    Task<Professor?> BuscarPorId(int id); 
    Task Adicionar(Professor professor);
    Task Atualizar(Professor professor);
    Task Deletar(Professor professor);
}