using AutoMapper;
using WebAPI_SprintAPI_Escola.DTOs;
using WebAPI_SprintAPI_Escola.Models;
using WebAPI_SprintAPI_Escola.Repositories;

namespace WebAPI_SprintAPI_Escola.Services;

public class ProfessorService : IProfessorService
{
    private readonly IProfessorRepository _repository;
    private readonly IMapper _mapper;

    public ProfessorService(IProfessorRepository repository, IMapper mapper)
    {
        _repository = repository;
        _mapper = mapper;
    }

    public async Task<IEnumerable<ProfessorDTO>> ListarTodos()
    {
        var professoresModel = await _repository.ListarTodos();
        return _mapper.Map<IEnumerable<ProfessorDTO>>(professoresModel);
    }

    public async Task<ProfessorDTO?> BuscarPorId(int id)
    {
        var professorModel = await _repository.BuscarPorId(id);
        return _mapper.Map<ProfessorDTO>(professorModel);
    }

    public async Task Adicionar(ProfessorDTO professorDto)
    {
        var professorModel = _mapper.Map<Professor>(professorDto);
        await _repository.Adicionar(professorModel);
    }

    public async Task Atualizar(int id, ProfessorDTO professorDto)
    {
        var professorModel = _mapper.Map<Professor>(professorDto);
        professorModel.IdProfessor = id;
        await _repository.Atualizar(professorModel);
    }

    public async Task Deletar(int id)
    {
        var professorModel = await _repository.BuscarPorId(id);
        if (professorModel != null)
        {
            await _repository.Deletar(professorModel);
        }
    }
}