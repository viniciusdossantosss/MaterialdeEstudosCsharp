using Livros.DTOs;
using Livros.Models;

namespace Livros.Services;

public interface ILivroService
{
    Task<IEnumerable<Livro>> ListarTodosOsLivros();
    Task Criar(LivroDTO livroDto);
}