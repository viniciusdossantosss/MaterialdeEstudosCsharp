using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Services;

public interface ITurmaService
{
    Task<IEnumerable<TurmaDTO>> ListarTodos();
    Task<TurmaDTO?> BuscarPorId(int id);
    Task Adicionar(TurmaDTO turmaDto);
    Task Atualizar(int id, TurmaDTO turmaDto);
    Task Deletar(int id);
}