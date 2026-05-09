using AutoMapper;
using WebAPI_SprintAPI_Escola.DTOs;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.Repositories;

namespace WebAPI_SprintAPI_Escola.Services;

public class DisciplinaService : IDisciplinaService
{
    private readonly IDisciplinaRepository _repository;
    private readonly IMapper _mapper;

    public DisciplinaService(IDisciplinaRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<DisciplinaDTO>> ListarTodos()
    {
        var disciplinasModel = await _repository.ListarTodos();
        return _mapper.Map<IEnumerable<DisciplinaDTO>>(disciplinasModel);
    }

    public async Task<DisciplinaDTO?> BuscarPorId(int id)
    {
        var disciplinaModel = await _repository.BuscarPorId(id);
        return _mapper.Map<DisciplinaDTO>(disciplinaModel);
    }

    public async Task Adicionar(DisciplinaDTO disciplinaDto)
    {
        var disciplinaModel = _mapper.Map<Disciplina>(disciplinaDto);
        await _repository.Adicionar(disciplinaModel);
    }

    public async Task Atualizar(int id, DisciplinaDTO disciplinaDto)
    {
        var disciplinaModel = _mapper.Map<Disciplina>(disciplinaDto);
        disciplinaModel.IdDisciplina = id;
        await _repository.Atualizar(disciplinaModel);
    }

    public async Task Deletar(int id)
    {
        var disciplinaModel = await _repository.BuscarPorId(id);
        if (disciplinaModel != null)
        {
            await _repository.Deletar(disciplinaModel);
        }
    }
}