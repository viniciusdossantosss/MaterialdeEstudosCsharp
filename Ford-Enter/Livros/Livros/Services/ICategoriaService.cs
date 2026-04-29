using Livros.DTOs;

namespace Livros.Services;

public interface ICategoriaService
{
    Task<IEnumerable<CategoriaDTO>> ListarTodasAsCategorias();
    Task CriarCategoria(CategoriaDTO categoriaDto);
}