using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Services;

public interface IAlunoService
{
    Task<IEnumerable<AlunoDTO>> ListarTodos();
    Task Adicionar(AlunoDTO alunoDTO);
    Task<AlunoDTO?> BuscarPorId(int id);
    Task Atualizar(int id, AlunoDTO alunoDto);
    Task Deletar(int id);
}