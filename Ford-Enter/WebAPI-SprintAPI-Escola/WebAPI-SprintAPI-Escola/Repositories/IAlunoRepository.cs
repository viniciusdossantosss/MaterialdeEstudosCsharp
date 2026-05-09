using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public interface IAlunoRepository
{
    Task<IEnumerable<Aluno>> ListarTodos();
    Task<Aluno?> BuscarPorId(int id); 
    Task Adicionar(Aluno aluno);
    Task Atualizar(Aluno aluno);
    Task Deletar(Aluno aluno);
}
