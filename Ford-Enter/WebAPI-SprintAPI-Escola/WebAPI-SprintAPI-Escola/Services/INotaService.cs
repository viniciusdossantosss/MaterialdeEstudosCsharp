using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Services;

public interface INotaService
{
    Task<IEnumerable<NotaDTO>> ListarTodos();
    Task<NotaDTO?> BuscarPorId(int id);
    Task Adicionar(NotaDTO notaDto);
    Task Atualizar(int id, NotaDTO notaDto);
    Task Deletar(int id);
}