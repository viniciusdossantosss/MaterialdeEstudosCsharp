using Livros.Models;

namespace Livros.Repositories;

public interface ICategoriaRepository
{
    Task<IEnumerable<Categoria>> ListarTodasAsCategorias();
    Task Adicionar(Categoria categoria);
}