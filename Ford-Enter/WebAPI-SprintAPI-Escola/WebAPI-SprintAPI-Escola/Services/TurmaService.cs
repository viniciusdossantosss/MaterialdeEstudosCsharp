using AutoMapper;
using WebAPI_SprintAPI_Escola.DTOs;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.Repositories;

namespace WebAPI_SprintAPI_Escola.Services;

public class TurmaService : ITurmaService
{
    private readonly ITurmaRepository _repository;
    private readonly IMapper _mapper;

    public TurmaService(ITurmaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<TurmaDTO>> ListarTodos()
    {
        var turmasModel = await _repository.ListarTodos();
        return _mapper.Map<IEnumerable<TurmaDTO>>(turmasModel);
    }

    public async Task<TurmaDTO?> BuscarPorId(int id)
    {
        var turmaModel = await _repository.BuscarPorId(id);
        return _mapper.Map<TurmaDTO>(turmaModel);
    }

    public async Task Adicionar(TurmaDTO turmaDto)
    {
        var turmaModel = _mapper.Map<Turma>(turmaDto);
        await _repository.Adicionar(turmaModel);
    }

    public async Task Atualizar(int id, TurmaDTO turmaDto)
    {
        var turmaModel = _mapper.Map<Turma>(turmaDto);
        turmaModel.IdTurma = id;
        await _repository.Atualizar(turmaModel);
    }

    public async Task Deletar(int id)
    {
        var turmaModel = await _repository.BuscarPorId(id);
        if (turmaModel != null)
        {
            await _repository.Deletar(turmaModel);
        }
    }
}