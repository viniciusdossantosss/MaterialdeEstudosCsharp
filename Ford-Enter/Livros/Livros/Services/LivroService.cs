using AutoMapper;
using Livros.DTOs;
using Livros.Repositories;
using Livros.Models;

namespace Livros.Services;

public class LivroService : ILivroService
{
    private readonly ILivroRepository _repository;
    private readonly IMapper _mapper;

    public LivroService(ILivroRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<LivroDTO>> ListarTodosOsLivros()
    { 
        var livros = await _repository.ListarTodosOsLivros();
        return _mapper.Map<IEnumerable<LivroDTO>>(livros);
    }
    
    public async Task Criar(LivroDTO livroDto)
    {
        if (livroDto.AnoPublicado > DateTime.Now.Year)
        {
            throw new Exception("Não é possivel publicar livros do futuro");
        }
        
        var livro = _mapper.Map<Livro>(livroDto);
        
        await _repository.Adicionar(livro);
    }
}
