using AutoMapper;
using WebAPI_SprintAPI_Escola.DTOs;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.Repositories;

namespace WebAPI_SprintAPI_Escola.Services;

public class NotaService : INotaService
{
    private readonly INotaRepository _repository;
    private readonly IMapper _mapper;

    public NotaService(INotaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<NotaDTO>> ListarTodos()
    {
        var notasModel = await _repository.ListarTodos();
        return _mapper.Map<IEnumerable<NotaDTO>>(notasModel);
    }

    public async Task<NotaDTO?> BuscarPorId(int id)
    {
        var notaModel = await _repository.BuscarPorId(id);
        return _mapper.Map<NotaDTO>(notaModel);
    }

    public async Task Adicionar(NotaDTO notaDto)
    {
        var notaModel = _mapper.Map<Nota>(notaDto);
        await _repository.Adicionar(notaModel);
    }

    public async Task Atualizar(int id, NotaDTO notaDto)
    {
        var notaModel = _mapper.Map<Nota>(notaDto);
        notaModel.IdNota = id;
        await _repository.Atualizar(notaModel);
    }

    public async Task Deletar(int id)
    {
        var notaModel = await _repository.BuscarPorId(id);
        if (notaModel != null)
        {
            await _repository.Deletar(notaModel);
        }
    }
}