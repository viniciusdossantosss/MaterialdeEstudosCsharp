using Livros.DTOs;
using Livros.Repositories;
using Livros.Models;
using Livros.DTOs;


namespace Livros.Services;

public class LivroService : ILivroService
{
    private readonly ILivroRepository _repository;

    public LivroService(ILivroRepository repository)
    {
        _repository = repository;
    }

    public async Task<IEnumerable<Livro>> ListarTodosOsLivros() =>
        await _repository.ListarTodos();

    public async Task Criar(LivroDTO livroDto)
    {
        if (livroDto.AnoPublicado > DateTime.Now.Year)
        {
            throw new Exception("Não é possivel publicar livros do futuro");
            var livro = new Livro
            {
                Titulo = livroDto.Titulo,
                Autor = livroDto.Autor,
                AnoPublicado = livroDto.AnoPublicado,
            };
        }
    }
}