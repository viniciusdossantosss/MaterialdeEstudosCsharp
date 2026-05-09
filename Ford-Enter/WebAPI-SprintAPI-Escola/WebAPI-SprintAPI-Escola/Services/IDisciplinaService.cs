using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Services;

public interface IDisciplinaService
{
    Task<IEnumerable<DisciplinaDTO>> ListarTodos();
    Task<DisciplinaDTO?> BuscarPorId(int id);
    Task Adicionar(DisciplinaDTO disciplinaDto);
    Task Atualizar(int id, DisciplinaDTO disciplinaDto);
    Task Deletar(int id);
}