using Livros.DTOs;

namespace Livros.Services;

public interface ILivroService
{
    Task<IEnumerable<LivroDTO>> ListarTodosOsLivros();
    Task Criar(LivroDTO livroDto);
}