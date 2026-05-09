using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public interface INotaRepository
{
    Task<IEnumerable<Nota>> ListarTodos();
    Task<Nota?> BuscarPorId(int id); 
    Task Adicionar(Nota nota);
    Task Atualizar(Nota nota);
    Task Deletar(Nota nota);
}