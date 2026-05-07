using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.DTOs;

namespace WebAPI_SprintAPI_Escola.Services;

public interface IAlunoService
{
    Task<IEnumerable<Aluno>> ListarTodos();
    Task Criar(AlunoDTO alunoDTO);
    Task<Aluno> BuscarPorId(int id);
    Task Atualizar(int id, AlunoDTO alunoDto);
    Task Deletar(int id);
}