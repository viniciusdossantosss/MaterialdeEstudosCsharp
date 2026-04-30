using Livros.Models;

namespace Livros.Repositories;

public interface ILivroRepository
{
    Task<IEnumerable<Livro>> ListarTodosOsLivros();
    Task Adicionar(Livro livro);
}

