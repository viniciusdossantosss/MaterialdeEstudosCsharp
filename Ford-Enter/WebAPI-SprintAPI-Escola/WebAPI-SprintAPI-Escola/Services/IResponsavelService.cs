using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Services;

public interface IResponsavelService
{
    Task<IEnumerable<ResponsavelDTO>> ListarTodos();
    Task<ResponsavelDTO?> BuscarPorId(int id);
    Task Adicionar(ResponsavelDTO responsavelDto);
    Task Atualizar(int id, ResponsavelDTO responsavelDto);
    Task Deletar(int id);
}