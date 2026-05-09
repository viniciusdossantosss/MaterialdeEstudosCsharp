using WebAPI_SprintAPI_Escola.Models;

namespace WebAPI_SprintAPI_Escola.Repositories;

public interface IResponsavelRepository
{
    Task<IEnumerable<Responsavel>> ListarTodos();
    Task<Responsavel?> BuscarPorId(int id); 
    Task Adicionar(Responsavel responsavel);
    Task Atualizar(Responsavel responsavel);
    Task Deletar(Responsavel responsavel);
}