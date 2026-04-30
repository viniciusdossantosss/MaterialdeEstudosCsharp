using Livros.Repositories;
using Livros.DTOs;
using Livros.Models;
using AutoMapper;

namespace Livros.Services;

public class CategoriaService : ICategoriaService
{
    private readonly ICategoriaRepository _repository;
    private readonly IMapper _mapper;

    public CategoriaService(ICategoriaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<CategoriaDTO>> ListarTodasAsCategorias()
    {
        var categorias = await _repository.ListarTodasAsCategorias();
        return _mapper.Map<IEnumerable<CategoriaDTO>>(categorias);
    }

    public async Task CriarCategoria(CategoriaDTO categoriaDto)
    {
        var categoria = _mapper.Map<Categoria>(categoriaDto);
        await _repository.Adicionar(categoria);
    }
}