using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Services;

public interface IProfessorService
{
    Task<IEnumerable<ProfessorDTO>> ListarTodos();
    Task<ProfessorDTO?> BuscarPorId(int id);
    Task Adicionar(ProfessorDTO professorDto);
    Task Atualizar(int id, ProfessorDTO professorDto);
    Task Deletar(int id);
}